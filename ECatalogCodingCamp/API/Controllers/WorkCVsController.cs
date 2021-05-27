using API.Base;
using API.Models;
using API.Repositories.Data;
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
    public class WorkCVsController : BaseController<WorkCV, WorkCVRepository, int>
    {
        private readonly WorkCVRepository workCVRepository;
        public WorkCVsController(WorkCVRepository workCVRepository) : base(workCVRepository)
        {
            this.workCVRepository = workCVRepository;
        }
    }
}