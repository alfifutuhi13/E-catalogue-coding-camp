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
    public class OrganizationCVsController : BaseController<OrganizationCV, OrganizationCVRepository, int>
    {
        private readonly OrganizationCVRepository organizationCVRepository;
        public OrganizationCVsController(OrganizationCVRepository organizationCVRepository) : base(organizationCVRepository)
        {
            this.organizationCVRepository = organizationCVRepository;
        }
    }
}