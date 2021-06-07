using API.Base;
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
    public class SkillsController : BaseController<Skill, SkillRepository, int>
    {
        private readonly SkillRepository skillRepository;
        private readonly IGenericDapper _dapper;
        public SkillsController(SkillRepository skillRepository, IGenericDapper dapper) : base(skillRepository)
        {
            this.skillRepository = skillRepository;
            _dapper = dapper;
        }

        [HttpPost("InsertSkill")]
        public ActionResult InsertSkill(InsertCVVM cv) 
        {
            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", cv.Email, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsertCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            int[] arrSkills = new int[cv.Skills.Count];

            for (int i = 0; i < cv.Skills.Count; i++)
            {
                var paramsGetSkillId = new DynamicParameters();
                paramsGetSkillId.Add("Name", cv.Skills[i].SkillName, DbType.String);
                var SkillId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Skill]", paramsGetSkillId, commandType: CommandType.StoredProcedure));

                var paramsInsertSkillCV = new DynamicParameters();
                paramsInsertSkillCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertSkillCV.Add("SkillId", SkillId.Result, DbType.Int32);
                var skillCV = _dapper.Insert<int>("[dbo].[SP_Insert_TB_T_SkillCV]", paramsInsertSkillCV, commandType: CommandType.StoredProcedure);
                arrSkills[i] = skillCV;
            }

            return Ok(new { result = arrSkills });
        }

        [HttpPut("UpdateSkill")]
        public ActionResult UpdateSkill(InsertCVVM cv) 
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
            var readToken = tokenHandler.ReadJwtToken(token);
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", getEmail, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_RetrieveCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            var paramsGetSkillId = new DynamicParameters();
            paramsGetSkillId.Add("CVId", CVId.Result, DbType.Int32);
            var SkillId = _dapper.GetAll<int>("[dbo].[SP_RetrieveSkillId]", paramsGetSkillId, commandType: CommandType.StoredProcedure);

            int[] arrSkills = new int[cv.Skills.Count];

            for (int i = 0; i < cv.Skills.Count; i++)
            {
                var paramUpdateSkill = new DynamicParameters();
                paramUpdateSkill.Add("SkillId", SkillId[i], DbType.Int32);
                paramUpdateSkill.Add("Name", cv.Skills[i].SkillName, DbType.String);
                var querySkill = _dapper.Insert<int>("[dbo].[SP_Update_TB_M_Skill]", paramUpdateSkill, commandType: CommandType.StoredProcedure);

                arrSkills[i] = querySkill;
            }

            return Ok(new { result = arrSkills });
        }
    }
}
