using API.Base;
using API.Context;
using API.Handlers;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController<Account, AccountRepository, int>
    {
        private readonly AccountRepository accountRepository;
        private readonly MyContext context;
        private IConfiguration _config;
        private readonly IGenericDapper _dapper;
        public AccountsController(AccountRepository accountRepository, MyContext context, IConfiguration config, IGenericDapper dapper) : base(accountRepository)
        {
            this.accountRepository = accountRepository;
            this.context = context;
            _config = config;
            _dapper = dapper;
        }

        [HttpPost("register/candidate")]
        public ActionResult RegisterCandidate(RegisterCandidateVM register)
        {

            var password = Hash.HashPassword(register.Password);
            var dbparams = new DynamicParameters();
            dbparams.Add("Name", register.Name, DbType.String);
            dbparams.Add("Email", register.Email, DbType.String);
            dbparams.Add("Password", password, DbType.String);
            dbparams.Add("BirthDate", register.BirthDate, DbType.String);
            dbparams.Add("Gender", register.Gender, DbType.String);
            dbparams.Add("Phone", register.Phone, DbType.String);
            dbparams.Add("JobRoleId", register.JobRoleId, DbType.String);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_RegisterCandidate]", dbparams, commandType: CommandType.StoredProcedure));
            return Ok();
           
        }

        [HttpPost("register/client")]
        public ActionResult RegisterClient(RegisterClientVM register)
        {

            var password = Hash.HashPassword(register.Password);
            var dbparams = new DynamicParameters();
            dbparams.Add("Name", register.Name, DbType.String);
            dbparams.Add("Email", register.Email, DbType.String);
            dbparams.Add("Password", password, DbType.String);
            dbparams.Add("Phone", register.Phone, DbType.String);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_RegisterClient]", dbparams, commandType: CommandType.StoredProcedure));
            return Ok();

        }

        //[HttpPost("login")]
        //public ActionResult Login(LoginVM login)
        //{
        //    var password = Hash.HashPassword(login.Password);

        //    var dbparams = new DynamicParameters();
        //    dbparams.Add("Email", login.Email, DbType.String);
        //    //dbparams.Add("Password", password, DbType.String);

        //    dynamic result = _dapper.Get<dynamic>("[dbo].[SP_Login]", dbparams, commandType: CommandType.StoredProcedure);

        //    //var user = context.Accounts.SingleOrDefault(a=>a.Employee.Email == login.Email);
        //    if (result != null && Hash.ValidatePassword(login.Password, result.Password))
        //    {

        //        var jwt = new JwtService(_config);
        //        var token = jwt.GenerateSecurityToken(result.Email, result.Name, result.Role);
        //        return Ok(token);
        //    }
        //    //try 
        //    //{
        //    //    var user = context.Accounts.SingleOrDefault(a => a.Email == account.Email);
        //    //    var role = context.Accounts.SingleOrDefault(a => a.Role.Id == user.Id);
        //    //    var passwordCheck = Hash.ValidatePassword(account.Password, user.Password);
        //    //    if (user != null && passwordCheck)
        //    //    {
        //    //        var jwt = new JwtService(_config);
        //    //        var token = jwt.GenerateSecurityToken(account.Email, account.Password, role.Role.Name);
        //    //        return Ok(token);
        //    //    }
        //    //    return BadRequest("Failed to login. Your email and password are not match.");
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    return BadRequest(e.InnerException);
        //    //}
        //    return BadRequest("Failed to login. Your email and password are not match");
        //}
    }
}
