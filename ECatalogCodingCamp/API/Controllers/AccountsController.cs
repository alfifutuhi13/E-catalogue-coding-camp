using API.Base;
using API.Context;
using API.Handlers;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.Services;
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

        [HttpPost("Login/")]
        public ActionResult Login(LoginVM login)
        {
            try
            {

                var dbparams = new DynamicParameters();
                dbparams.Add("Email", login.Email, DbType.String);
                dynamic result = _dapper.Get<dynamic>("[dbo].[SP_Login]"
                , dbparams,
                commandType: CommandType.StoredProcedure);

                if (Hash.ValidatePassword(login.Password, result.Password))
                {
                    var jwt = new JwtService(_config);
                    var token = jwt.GenerateSecurityLoginToken(result.Name, result.Email, result.Role);
                    return Ok(new { token });
                }

                return Unauthorized("Failed To Make Token, Email / Password Wrong");
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException);

            }

        }

        [HttpPost("Change-Password")]
        public ActionResult ChangePassword()
        {

            string email = Request.Headers["Email"].ToString();
            string currentPassword = Request.Headers["CurrentPassword"].ToString();
            string newPassword = Request.Headers["NewPassword"].ToString();
            string confirmPassword = Request.Headers["ConfirmPassword"].ToString();
            var foundAccount = context.Accounts.Where(account => account.User.Email == email).FirstOrDefault();

            if (foundAccount == null || !Hash.ValidatePassword(currentPassword, foundAccount.Password))
            {
                return NotFound("Wrong Email / Current Password");
            }
            else if (newPassword != confirmPassword)
            {
                return BadRequest("New Password & Confirm Password Must Same");
            }
            else
            {
                string passwordHash = Hash.HashPassword(newPassword);
                foundAccount.Password = passwordHash;
                var result = accountRepository.Put(foundAccount) > 0 ? (ActionResult)Ok("Data has been successfully updated.") : BadRequest("Data can't be updated.");
                return result;
            }

        }

    }
}
