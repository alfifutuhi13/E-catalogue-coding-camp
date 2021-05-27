using API.Base;
using API.Context;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
    }
}
