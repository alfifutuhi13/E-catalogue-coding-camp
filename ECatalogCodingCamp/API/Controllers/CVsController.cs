using API.Base;
using API.Context;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class CVsController : BaseController<CV, CVRepository, int>
    {
        private readonly CVRepository cvRepository;
        private readonly MyContext context;
        private readonly IGenericDapper _dapper;
        public CVsController(CVRepository cvRepository, MyContext context, IGenericDapper dapper) : base(cvRepository)
        {
            this.cvRepository = cvRepository;
            this.context = context;
            _dapper = dapper;
        }

        [HttpPost("CV")]
        public ActionResult InsertCV(InsertCVVM insert)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Query["Token"]);
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var foundCandidate = context.Users.Where(user => user.Email == getEmail).FirstOrDefault();

            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", foundCandidate.Email, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsertCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            var paramsGetOrganizationId = new DynamicParameters();
            paramsGetOrganizationId.Add("Name", insert.OrganizationName, DbType.String);
            paramsGetOrganizationId.Add("RoleOrganization", insert.RoleOrganization, DbType.String);
            var OrganizationId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Organization]", paramsGetOrganizationId, commandType: CommandType.StoredProcedure));

            var paramsGetSkillId = new DynamicParameters();
            paramsGetSkillId.Add("Name", insert.SkillName, DbType.String);
            var SkillId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Skill]", paramsGetSkillId, commandType: CommandType.StoredProcedure));
            var paramsGetWorkId = new DynamicParameters();
            paramsGetWorkId.Add("Name", insert.WorkName, DbType.String);
            var WorkId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Work]", paramsGetWorkId, commandType: CommandType.StoredProcedure));

            var paramsInsertOrganizationCV = new DynamicParameters();
            paramsInsertOrganizationCV.Add("CVId", CVId, DbType.Int32);
            paramsInsertOrganizationCV.Add("OrgId", OrganizationId, DbType.Int32);
            var OrganizationCV = Task.FromResult(_dapper.Insert<dynamic>("[dbo].[SP_Insert_TB_T_OrganizationCV]", paramsInsertOrganizationCV, commandType: CommandType.StoredProcedure));

            var paramsInsertSkillCV = new DynamicParameters();
            paramsInsertSkillCV.Add("CVId", CVId, DbType.Int32);
            paramsInsertSkillCV.Add("SkillId", SkillId, DbType.Int32);
            var SkillCV = Task.FromResult(_dapper.Insert<dynamic>("[dbo].[SP_Insert_TB_T_SkillCV]", paramsInsertSkillCV, commandType: CommandType.StoredProcedure));

            var paramsInsertWorkCV = new DynamicParameters();
            paramsInsertWorkCV.Add("CVId", CVId, DbType.Int32);
            paramsInsertWorkCV.Add("WorkId", WorkId, DbType.Int32);
            var WorkCV = Task.FromResult(_dapper.Insert<dynamic>("[dbo].[SP_Insert_TB_T_WorkCV]", paramsInsertWorkCV, commandType: CommandType.StoredProcedure));

            return Ok(new { message = "CV has been updated." });
        }
    }
}
