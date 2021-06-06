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
        public UsersController(UserRepository userRepository, IGenericDapper _dapper, IConfiguration config) : base(userRepository)
        {
            this.userRepository = userRepository;
            this._dapper = _dapper;
            this.config = config;
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
