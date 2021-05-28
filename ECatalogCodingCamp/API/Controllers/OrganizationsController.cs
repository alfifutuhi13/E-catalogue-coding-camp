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
    public class OrganizationsController : BaseController<Organization, OrganizationRepository, int>
    {
        private readonly OrganizationRepository organizationRepository;
        public OrganizationsController(OrganizationRepository organizationRepository) : base(organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
    }
}
