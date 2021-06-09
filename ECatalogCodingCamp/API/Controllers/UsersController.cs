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
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User, UserRepository, int>
    {
        private readonly UserRepository userRepository;
        private readonly IConfiguration config;
        private readonly IGenericDapper _dapper;
        private readonly MyContext context;
        public UsersController(UserRepository userRepository, IGenericDapper _dapper, IConfiguration config, MyContext context) : base(userRepository)
        {
            this.userRepository = userRepository;
            this._dapper = _dapper;
            this.config = config;
            this.context = context;
        }

        [HttpGet("GetUser")]
        public dynamic GetUser()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            dbparams.Add("Email", getEmail, DbType.String);
            return db.Query<dynamic>("[dbo].[SP_GetUser]", dbparams, commandType: CommandType.StoredProcedure);
            //var result = (_dapper.Get<dynamic>("[dbo].[SP_RetrieveEducation]", dbparams, commandType: CommandType.StoredProcedure);
        }

        [HttpGet("Detail/{id}")]
        public ActionResult Detail(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            //var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            //var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            dbparams.Add("Id", id, DbType.Int32);
            var queryResult =  _dapper.Get<dynamic>("[dbo].[SP_GetDetail]", dbparams, commandType: CommandType.StoredProcedure);  
            return Ok(queryResult);
            //var result = (_dapper.Get<dynamic>("[dbo].[SP_RetrieveEducation]", dbparams, commandType: CommandType.StoredProcedure);
        }

        [HttpGet("DetailCV/{id}")]
        public ActionResult DetailCV(int id) 
        {
            var foundUser = context.Users.FirstOrDefault(u => u.Id == id);
            var getEmail = foundUser.Email;

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
                Id = id,
                Organizations = queryOrg,
                Skills = querySkill,
                Works = queryWork
            };
            return Ok(queryObject);
        }

        [HttpPut("Update-Profile")]
        public ActionResult UpdateProfile(ProfileVM profile)
        {

            var dbparams = new DynamicParameters();
            dbparams.Add("Email", profile.Email, DbType.String);
            dbparams.Add("Name", profile.Name, DbType.String);
            dbparams.Add("Id", profile.Id, DbType.Int32);
            dbparams.Add("Phone", profile.Phone, DbType.String);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Update_TB_M_User]", dbparams, commandType: CommandType.StoredProcedure));

            return Ok(new { result = result, message = "Education has been updated." });
        }
    }
}
