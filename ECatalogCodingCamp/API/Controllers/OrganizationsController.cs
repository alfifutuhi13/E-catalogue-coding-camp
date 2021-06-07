using API.Base;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : BaseController<Organization, OrganizationRepository, int>
    {
        private readonly OrganizationRepository organizationRepository;
        private readonly IConfiguration config;
        private readonly IGenericDapper _dapper;
        public OrganizationsController(OrganizationRepository organizationRepository, IConfiguration config, IGenericDapper dapper) : base(organizationRepository)
        {
            this.organizationRepository = organizationRepository;
            this.config = config;
            _dapper = dapper;
        }

        [HttpPost("InsertOrganization")]
        public ActionResult InsertOrganization(InsertCVVM cv) 
        {
            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", cv.Email, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsertCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            int[] arrOrganization = new int[cv.Organizations.Count] ;

            //looping
            for (int i = 0; i < cv.Organizations.Count; i++)
            {
                var paramsGetOrganizationId = new DynamicParameters();
                paramsGetOrganizationId.Add("Name", cv.Organizations[i].OrganizationName, DbType.String);
                paramsGetOrganizationId.Add("RoleOrganization", cv.Organizations[i].RoleOrganization, DbType.String);
                var OrganizationId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Organization]", paramsGetOrganizationId, commandType: CommandType.StoredProcedure));

                var paramsInsertOrganizationCV = new DynamicParameters();
                paramsInsertOrganizationCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertOrganizationCV.Add("OrgId", OrganizationId.Result, DbType.Int32);
                var organizationCV = _dapper.Insert<int>("[dbo].[SP_Insert_TB_T_OrganizationCV]", paramsInsertOrganizationCV, commandType: CommandType.StoredProcedure);
                arrOrganization[i] = organizationCV;
            }
            return Ok(new { result = arrOrganization });
        }

        [HttpPut("UpdateOrganization")]
        public ActionResult UpdateOrganization(InsertCVVM cv) 
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
            var readToken = tokenHandler.ReadJwtToken(token);
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", getEmail, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_RetrieveCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            var paramsGetOrganizationId = new DynamicParameters();
            paramsGetOrganizationId.Add("CVId", CVId.Result, DbType.Int32);
            var OrganizationId = _dapper.GetAll<int>("[dbo].[SP_RetrieveOrganizationId]", paramsGetOrganizationId, commandType: CommandType.StoredProcedure);

            int[] arrOrganization = new int[cv.Organizations.Count];

            //looping
            for (int i = 0; i < cv.Organizations.Count; i++)
            {
                var paramUpdateOrganization = new DynamicParameters();
                paramUpdateOrganization.Add("OrgId", OrganizationId[i], DbType.Int32);
                paramUpdateOrganization.Add("Name", cv.Organizations[i].OrganizationName, DbType.String);
                paramUpdateOrganization.Add("RoleOrganization", cv.Organizations[i].RoleOrganization, DbType.String);
                var queryOrg = _dapper.Insert<int>("[dbo].[SP_Update_TB_M_Organization]", paramUpdateOrganization, commandType: CommandType.StoredProcedure);
                arrOrganization[i] = queryOrg;
            }

            return Ok(new { result = arrOrganization});
        }
    }
}
