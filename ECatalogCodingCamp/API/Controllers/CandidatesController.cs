using API.Base;
using API.Context;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    //[Authorize(Roles = "Client,Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : BaseController<Candidate, CandidateRepository, int>
    {
        private readonly CandidateRepository candidateRepository;
        private readonly MyContext context;
        private readonly IConfiguration configuration;

        public CandidatesController(CandidateRepository candidateRepository, MyContext context, IConfiguration configuration) : base(candidateRepository)
        {
            this.candidateRepository = candidateRepository;
            this.context = context;
            this.configuration = configuration;
        }

        [HttpGet("GetCandidates")]
        public IEnumerable<dynamic> GetCandidates()
        {
            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(configuration.GetConnectionString("MyConnection"));
            return db.Query<dynamic>("[dbo].[SP_GetCandidates]", dbparams, commandType: CommandType.StoredProcedure);
        }

    }
}
