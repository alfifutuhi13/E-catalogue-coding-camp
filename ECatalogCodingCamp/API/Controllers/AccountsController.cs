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
        private SendEmail sendEmail;
        private AccountRepository accountRepository;
        private MyContext context;
        private IConfiguration _config;
        private readonly IGenericDapper _dapper;

        public AccountsController(AccountRepository accountRepository, MyContext context, IConfiguration _config, SendEmail sendEmail, IGenericDapper dapperr) : base(accountRepository)
        {
            this.accountRepository = accountRepository;
            this.context = context;
            this._config = _config;
            this.sendEmail = sendEmail;
            _dapper = dapperr;
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
    }
}
