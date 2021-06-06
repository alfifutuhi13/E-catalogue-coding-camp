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
    public class EducationsController : BaseController<Education, EducationRepository, int>
    {
        private readonly EducationRepository educationRepository;
        private readonly MyContext context;
        private readonly IGenericDapper _dapper;
        public EducationsController(EducationRepository educationRepository, MyContext context, IGenericDapper dapper) : base(educationRepository)
        {
            this.educationRepository = educationRepository;
            this.context = context;
            _dapper = dapper;
        }

        [Authorize (Roles = "Candidate")]
        [HttpPost("Insert-Education")]
        public ActionResult InsertEducation(EducationVM educationVM)
        {
            //var tokenHandler = new JwtSecurityTokenHandler();
            //var readToken = tokenHandler.ReadJwtToken(Request.Query["Token"]);
            //var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            //var foundCandidate = context.Users.Where(user => user.Email == getEmail).FirstOrDefault();

            var dbparams = new DynamicParameters();
            dbparams.Add("Email", educationVM.Email, DbType.String);
            dbparams.Add("Major", educationVM.Major, DbType.String);
            dbparams.Add("Univ", educationVM.University, DbType.String);
            dbparams.Add("Degree", educationVM.Degree, DbType.String);
            dbparams.Add("GPA", educationVM.GPA, DbType.Double);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Insert_TB_T_Education]", dbparams, commandType: CommandType.StoredProcedure));

            return Ok(new { result = result, message = "Education has been updated." });
        }

        //[Authorize(Roles = "Candidate")]
        //[HttpPost("GetAllData")]
        //public ActionResult GetAllData(EducationVM educationVM)
        //{
        //    var dbparams = new DynamicParameters();
        //    dbparams.Add("Email", educationVM.Email, DbType.String);
        //    var result = Task.FromResult(_dapper.Get<int>("[dbo].[SP_RetrieveEducation]", dbparams, commandType: CommandType.StoredProcedure));
        //    return Ok(result);
        //}

    }
}
