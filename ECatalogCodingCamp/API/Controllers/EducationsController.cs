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
    public class EducationsController : BaseController<Education, EducationRepository, int>
    {
        private readonly EducationRepository educationRepository;
        private readonly MyContext context;
        private readonly IConfiguration config;
        private readonly IGenericDapper _dapper;
        public EducationsController(EducationRepository educationRepository, MyContext context, IGenericDapper dapper, IConfiguration config) : base(educationRepository)
        {
            this.educationRepository = educationRepository;
            this.context = context;
            _dapper = dapper;
            this.config = config;
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

        [Authorize(Roles = "Candidate")]
        [HttpGet("GetAllData")]
        public dynamic GetAllData()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            dbparams.Add("Email", getEmail, DbType.String);
            return db.Query<dynamic>("[dbo].[SP_RetrieveEducation]", dbparams, commandType: CommandType.StoredProcedure);
            //var result = (_dapper.Get<dynamic>("[dbo].[SP_RetrieveEducation]", dbparams, commandType: CommandType.StoredProcedure);
        }

    }
}
