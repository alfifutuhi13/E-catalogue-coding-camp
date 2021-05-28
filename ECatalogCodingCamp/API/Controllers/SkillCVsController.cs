using API.Base;
using API.Models;
using API.Repositories.Data;
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
    public class SkillCVsController : BaseController<SkillCV, SkillCVRepository, int>
    {
        private readonly SkillCVRepository skillCVRepository;
        public SkillCVsController(SkillCVRepository skillCVRepository) : base(skillCVRepository)
        {
            this.skillCVRepository = skillCVRepository;
        }
    }
}