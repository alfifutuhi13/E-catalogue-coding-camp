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
    public class EducationsController : BaseController<Education, EducationRepository, int>
    {
        private readonly EducationRepository educationRepository;
        public EducationController(EducationRepository educationRepository) : base(educationRepository)
        {
            this.educationRepository = educationRepository;
        }
    }
}
