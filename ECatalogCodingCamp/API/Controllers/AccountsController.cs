using API.Base;
using API.Context;
using API.Handlers;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.Services;
using API.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
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

        [HttpPost("register")]
        public ActionResult Register(RegisterVM register)
        {
            var password = Hash.HashPassword(register.Password);
            var dbparams = new DynamicParameters();
            dbparams.Add("Name", register.Name, DbType.String);
            dbparams.Add("Email", register.Email, DbType.String);
            dbparams.Add("Password", password, DbType.String);
            dbparams.Add("BirthDate", register.BirthDate, DbType.String);
            dbparams.Add("Gender", register.Gender, DbType.String);
            dbparams.Add("Phone", register.Phone, DbType.String);
            dbparams.Add("JobRoleId", register.JobRoleId, DbType.Int32);
            dbparams.Add("RoleId", register.RoleId, DbType.Int32);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_Register]", dbparams, commandType: CommandType.StoredProcedure));
            return Ok(new { result = result, message = "Successfully registered." });

        }

        [HttpPost("register/admin")]
        public ActionResult RegisterAdmin(RegisterClientAdminVM register)
        {
            var password = Hash.HashPassword(register.Password);
            var dbparams = new DynamicParameters();
            dbparams.Add("Name", register.Name, DbType.String);
            dbparams.Add("Email", register.Email, DbType.String);
            dbparams.Add("Password", password, DbType.String);
            dbparams.Add("Phone", register.Phone, DbType.String);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_RegisterAdmin]", dbparams, commandType: CommandType.StoredProcedure));
            return Ok(new { result = result, message = "Successfully registered." });

        }

        [HttpPost("Login")]
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
                    return Ok(token);
                }

                return Unauthorized("Failed to log in, your email or password Wrong");
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException);

            }

        }

        [Authorize]
        [HttpPut("Change-Password")]
        public ActionResult ChangePassword(ChangePasswordVM changePasswordVM)
        {
            var jwt = new JwtSecurityTokenHandler();
            var jwtRead = jwt.ReadJwtToken(changePasswordVM.Token);

            var foundEmail = jwtRead.Claims.First(email => email.Type == "email").Value;

            var foundAccount = context.Accounts.Where(account => account.User.Email == foundEmail).FirstOrDefault();

            if (foundAccount == null || !Hash.ValidatePassword(changePasswordVM.CurrentPassword, foundAccount.Password))
            {
                return NotFound(new { message = "Your email or your current password is incorrect" });
            }
            else if (changePasswordVM.NewPassword != changePasswordVM.ConfirmPassword)
            {
                return BadRequest(new { message = "New password & confirmation password should be identical" });
            }
            else
            {
                string passwordHash = Hash.HashPassword(changePasswordVM.NewPassword);
                foundAccount.Password = passwordHash;
                var result = accountRepository.Put(foundAccount) > 0 ? (ActionResult)Ok(new { message = "Password has been successfully updated." }) : BadRequest(new { message = "Password can't be updated." });
                return result;
            }
        }

        [HttpPost("Forgot-Password")]
        public ActionResult ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            //string headerEmail = Request.Headers["Email"].ToString();
            var foundAccount = context.Accounts.Where(account => account.User.Email == forgotPasswordVM.Email).FirstOrDefault();
            if (foundAccount == null)
            {
                return NotFound(new { message = "Email Not Found" });
            }
            else
            {
                var foundUser = context.Users.Where(user => user.Id == foundAccount.Id).FirstOrDefault();
                var jwt = new JwtService(_config);
                string token = jwt.GenerateSecurityForgotToken(forgotPasswordVM.Email);
                string url = "https://localhost:44354/Authentication/Reset?Token=";

                var sendEmail = new SendEmail(context);
                sendEmail.SendForgotPassword(url, token, foundUser);
                return Ok(new { message = "Please Check Your Email" });

            }

        }

        
        [HttpPut("Reset-Password")]
        public ActionResult ResetPassword(ChangePasswordVM changePasswordVM)
        {
            string token = changePasswordVM.Token;
            var tokenHandler = new JwtSecurityTokenHandler();
            var readToken = tokenHandler.ReadJwtToken(token);

            if (changePasswordVM.NewPassword == changePasswordVM.ConfirmPassword)
            {
                var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;
                var foundAccount = context.Accounts.Where(account => account.User.Email == getEmail).FirstOrDefault();

                if (foundAccount == null)
                {
                    return NotFound(new { message = "Email not found" });
                }
                else
                {
                    string passwordHash = Hash.HashPassword(changePasswordVM.NewPassword);
                    foundAccount.Password = passwordHash;
                    var result = accountRepository.Put(foundAccount) > 0 ? (ActionResult)Ok(new { message = "Password has been updated." }) : BadRequest(new { message = "Password can't be updated." });
                    return result;
                }
            }
            else
            {
                return BadRequest(new { message = "New password & confirmation password should be identical" });
            }
        }  
    } 
}
