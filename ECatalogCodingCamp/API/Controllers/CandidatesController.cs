using API.Base;
using API.Context;
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

    [Authorize(Roles = "Client,Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : BaseController<Candidate, CandidateRepository, int>
    {
        private readonly CandidateRepository candidateRepository;
        private readonly MyContext context;

        public CandidatesController(CandidateRepository candidateRepository, MyContext context) : base(candidateRepository)
        {
            this.candidateRepository = candidateRepository;
            this.context = context;
        }
    }
}
