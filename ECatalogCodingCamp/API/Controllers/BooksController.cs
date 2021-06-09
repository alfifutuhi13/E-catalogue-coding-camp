using API.Base;
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
        public BooksController(BookRepository bookRepository, IGenericDapper _dapper, IConfiguration config) : base(bookRepository)
        {
            this.bookRepository = bookRepository;
            this._dapper = _dapper;
            this.config = config;
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
        [HttpGet("GetInterviewRequest/{id}")]
        public dynamic GetInterviewRequests(int id) 
        {
            var paramsGetClient = new DynamicParameters();
            using IDbConnection db = new SqlConnection(config.GetConnectionString("MyConnection"));
            paramsGetClient.Add("UserId", id, DbType.Int32);
            return db.Query<dynamic>("[dbo].[SP_RetrieveInterviewRequest]", paramsGetClient, commandType: CommandType.StoredProcedure);
        }
    }
}
