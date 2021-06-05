using API.Base;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class JobRolesController : BaseController<JobRole, JobRoleRepository, int>
    {
        private readonly JobRoleRepository jobRoleRepository;
        private readonly IGenericDapper _dapper;

        public JobRolesController(JobRoleRepository jobRoleRepository, IGenericDapper dapper) : base(jobRoleRepository)
        {
            this.jobRoleRepository = jobRoleRepository;
            _dapper = dapper;
        }

        [AllowAnonymous]
        [HttpGet("Job/{id}")]
        public IActionResult GetJobRoles(int id)
        {
            var dbparam = new DynamicParameters();
            dbparam.Add("Id", id, DbType.Int32);
            var result = _dapper.GetAll<int>(
                "[dbo].[SP_GetJobRoles]",
                dbparam, CommandType.StoredProcedure);
            return Ok(result);
        }
    }

    
}
