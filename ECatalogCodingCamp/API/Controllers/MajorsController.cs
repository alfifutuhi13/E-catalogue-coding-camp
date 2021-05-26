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
    public class MajorsController : BaseController<Major, MajorRepository, int>
    {
        private readonly MajorRepository majorRepository;
        public MajorsController(MajorRepository majorRepository) : base(majorRepository)
        {
            this.majorRepository = majorRepository;
        }
    }
}
