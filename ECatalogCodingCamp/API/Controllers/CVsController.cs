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
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private readonly IConfiguration config;
        public CVsController(CVRepository cvRepository, MyContext context, IGenericDapper dapper, IConfiguration config) : base(cvRepository)
        {
            this.cvRepository = cvRepository;
            this.context = context;
            _dapper = dapper;
            this.config = config;
        }


        [HttpPost("InsertCV")]
        public ActionResult InsertCV(InsertCVVM insert)
        {
            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", insert.Email, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsertCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            //looping
            for (int i = 0; i < insert.Organizations.Count; i++)
            {
                var paramsGetOrganizationId = new DynamicParameters();
                paramsGetOrganizationId.Add("Name", insert.Organizations[i].OrganizationName, DbType.String);
                paramsGetOrganizationId.Add("RoleOrganization", insert.Organizations[i].RoleOrganization, DbType.String);
                var OrganizationId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Organization]", paramsGetOrganizationId, commandType: CommandType.StoredProcedure));

                var paramsInsertOrganizationCV = new DynamicParameters();
                paramsInsertOrganizationCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertOrganizationCV.Add("OrgId", OrganizationId.Result, DbType.Int32);
                var OrganizationCV = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Insert_TB_T_OrganizationCV]", paramsInsertOrganizationCV, commandType: CommandType.StoredProcedure));
            }

            for (int i = 0; i < insert.Skills.Count; i++)
            {
                var paramsGetSkillId = new DynamicParameters();
                paramsGetSkillId.Add("Name", insert.Skills[i].SkillName, DbType.String);
                var SkillId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Skill]", paramsGetSkillId, commandType: CommandType.StoredProcedure));

                var paramsInsertSkillCV = new DynamicParameters();
                paramsInsertSkillCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertSkillCV.Add("SkillId", SkillId.Result, DbType.Int32);
                var SkillCV = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Insert_TB_T_SkillCV]", paramsInsertSkillCV, commandType: CommandType.StoredProcedure));

            }

            for (int i = 0; i < insert.Works.Count; i++)
            {
                var paramsGetWorkId = new DynamicParameters();
                paramsGetWorkId.Add("Name", insert.Works[i].WorkName, DbType.String);
                var WorkId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Work]", paramsGetWorkId, commandType: CommandType.StoredProcedure));

                var paramsInsertWorkCV = new DynamicParameters();
                paramsInsertWorkCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertWorkCV.Add("WorkId", WorkId.Result, DbType.Int32);
                var WorkCV = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Insert_TB_T_WorkCV]", paramsInsertWorkCV, commandType: CommandType.StoredProcedure));
            }

            return Ok(new { message = "CV has been updated." });
        }

        [HttpPut("UpdateCV")]
        public ActionResult UpdateCV(InsertCVVM cv)
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

            var paramsGetSkillId = new DynamicParameters();
            paramsGetSkillId.Add("CVId", CVId.Result, DbType.Int32);
            var SkillId = _dapper.GetAll<int>("[dbo].[SP_RetrieveSkillId]", paramsGetSkillId, commandType: CommandType.StoredProcedure);

            var paramsGetWorkId = new DynamicParameters();
            paramsGetWorkId.Add("CVId", CVId.Result, DbType.Int32);
            var WorkId = _dapper.GetAll<int>("[dbo].[SP_RetrieveWorkId]", paramsGetWorkId, commandType: CommandType.StoredProcedure);

            //looping
            for (int i = 0; i < cv.Organizations.Count; i++)
            {
                var paramUpdateOrganization = new DynamicParameters();
                paramUpdateOrganization.Add("OrgId", OrganizationId[i], DbType.Int32);
                paramUpdateOrganization.Add("Name", cv.Organizations[i].OrganizationName, DbType.String);
                paramUpdateOrganization.Add("RoleOrganization", cv.Organizations[i].RoleOrganization, DbType.String);
                var queryOrg = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Update_TB_M_Organization]", paramUpdateOrganization, commandType: CommandType.StoredProcedure));
            }

            for (int i = 0; i < cv.Skills.Count; i++)
            {
                var paramUpdateSkill = new DynamicParameters();
                paramUpdateSkill.Add("SkillId", SkillId[i], DbType.Int32);
                paramUpdateSkill.Add("Name", cv.Skills[i].SkillName, DbType.String);
                var querySkill = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Update_TB_M_Skill]", paramUpdateSkill, commandType: CommandType.StoredProcedure));

            }

            for (int i = 0; i < cv.Works.Count; i++)
            {
                var paramUpdateWork = new DynamicParameters();
                paramUpdateWork.Add("WorkId", WorkId[i], DbType.Int32);
                paramUpdateWork.Add("Name", cv.Works[i].WorkName, DbType.String);
                var queryWork = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Update_TB_M_Work]", paramUpdateWork, commandType: CommandType.StoredProcedure));
            }

            return Ok(new { message = "CV has been updated." });
        }
        [HttpGet("Experience")]
        public dynamic GetAllExp()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", getEmail, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_RetrieveCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            var paramOrg = new DynamicParameters();
            var paramSkill = new DynamicParameters();
            var paramWork = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            paramOrg.Add("Email", getEmail, DbType.String);
            var queryOrg = db.Query<dynamic>("[dbo].[SP_RetrieveOrganization]", paramOrg, commandType: CommandType.StoredProcedure);

            paramSkill.Add("Email", getEmail, DbType.String);
            var querySkill = db.Query<dynamic>("[dbo].[SP_RetrieveSkill]", paramSkill, commandType: CommandType.StoredProcedure);

            paramWork.Add("Email", getEmail, DbType.String);
            var queryWork = db.Query<dynamic>("[dbo].[SP_RetrieveWork]", paramWork, commandType: CommandType.StoredProcedure);

            var queryObject = new
            {
                Id = CVId.Result,
                Organizations = queryOrg,
                Skills = querySkill,
                Works = queryWork
            };

            return queryObject;
        }
    }
}
