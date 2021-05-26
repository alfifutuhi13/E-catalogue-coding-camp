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
    public class SkillsController : BaseController<Skill, SkillRepository, int>
    {
        private readonly SkillRepository skillRepository;
        public SkillController(SkillRepository skillRepository) : base(skillRepository)
        {
            this.skillRepository = skillRepository;
        }
    }
}
