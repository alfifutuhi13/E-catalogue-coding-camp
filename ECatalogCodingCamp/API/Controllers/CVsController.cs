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
    public class CVsController : BaseController<CV, CVRepository, int>
    {
        private readonly CVRepository cvRepository;
        public CVController(CVRepository cvRepository) : base(cvRepository)
        {
            this.cvRepository = cvRepository;
        }
    }
}
