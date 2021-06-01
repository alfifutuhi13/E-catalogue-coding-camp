using API.Base;
using API.Context;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CVsController : BaseController<CV, CVRepository, int>
    {
        private readonly CVRepository cvRepository;
        private readonly MyContext context;
        private readonly IGenericDapper _dapper;
        public CVsController(CVRepository cvRepository, MyContext context, IGenericDapper dapper) : base(cvRepository)
        {
            this.cvRepository = cvRepository;
            this.context = context;
            _dapper = dapper;
        }

        //[HttpPost("CV")]
        //public ActionResult InsertCV() 
        //{ 
        
        //}
    }
}
