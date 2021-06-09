using API.Base;
using API.Context;
using API.Handlers;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
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
    public class BooksController : BaseController<Book, BookRepository, int>
    {
        private readonly BookRepository bookRepository;
        private readonly IGenericDapper _dapper;
        private readonly IConfiguration config;
        private readonly MyContext context;
        public BooksController(BookRepository bookRepository, IGenericDapper _dapper, IConfiguration config, MyContext context) : base(bookRepository)
        {
            this.bookRepository = bookRepository;
            this._dapper = _dapper;
            this.config = config;
            this.context = context;
        }

        [HttpGet("GetClient/{id}")]
        public dynamic GetClient(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetClient = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            paramsGetClient.Add("Id", id, DbType.Int32);
            return db.Query<dynamic>("[dbo].[SP_GetClient]", paramsGetClient, commandType: CommandType.StoredProcedure);

        }

        [HttpGet("GetCandidate")]
        public dynamic GetCandidate()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            dbparams.Add("Email", getEmail, DbType.String);
            return db.Query<dynamic>("[dbo].[SP_GetCandidate]", dbparams, commandType: CommandType.StoredProcedure);
        }

        [HttpGet("GetClientId")]
        public dynamic GetClientId()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            dbparams.Add("Email", getEmail, DbType.String);
            return db.Query<dynamic>("[dbo].[SP_GetClientId]", dbparams, commandType: CommandType.StoredProcedure);
        }

        [HttpGet("GetCandidate/{id}")]
        public dynamic GetCandidate(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetClient = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            paramsGetClient.Add("Id", id, DbType.Int32);
            return db.Query<dynamic>("[dbo].[SP_GetCandidateInterview]", paramsGetClient, commandType: CommandType.StoredProcedure);

        }

        [HttpDelete("Rejected/{id}")]
        public IActionResult Rejected(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var emailClient = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var foundClient = context.Users.Where(user => user.Email == emailClient).FirstOrDefault();
            var nameClient = foundClient.Name;

            var foundCandidate = context.Users.Where(user => user.Id == id).FirstOrDefault();
            var candidateName = foundCandidate.Name;
            var candidateEmail = foundCandidate.Email;
            var message = "Thank you for your time, but your not suitable for this job";

            var paramsGetClient = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            paramsGetClient.Add("Id", id, DbType.Int32);
            var result =  db.Query<dynamic>("[dbo].[SP_Rejected]", paramsGetClient, commandType: CommandType.StoredProcedure);

            var sendEmail = new SendEmail(context);
            sendEmail.SendRejected(candidateEmail, nameClient, candidateName, message);
            return Ok(new { result = result, message = "Candidate Has Been Rejected" });
        }
    }
}
