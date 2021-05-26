using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController<Account, AccountR, int>
    {
        private readonly SubDistrictRepository subDistrictRepository;
        public SubDistrictsController(SubDistrictRepository subDistrictRepository) : base(subDistrictRepository)
        {
            this.subDistrictRepository = subDistrictRepository;
        }
    }
}
