using API.Base;
using API.Context;
using API.Models;
using API.Repositories.Data;
using API.Repositories.Interface;
using API.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize(Roles = "Client,Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewRequestsController : BaseController<InterviewRequest, InterviewRequestRepository, int>
    {
        private readonly InterviewRequestRepository interviewRequestRepository;
        private readonly MyContext context;
        private readonly IGenericDapper _dapper;
        public InterviewRequestsController(InterviewRequestRepository interviewRequestRepository, MyContext context, IGenericDapper dapper) : base(interviewRequestRepository)
        {
            this.interviewRequestRepository = interviewRequestRepository;
            this.context = context;
            _dapper = dapper;
        }

        [HttpPost("Interview-Request")]
        public ActionResult InterviewRequest(InterviewRequestVM interviewRequestVM)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            //var readToken = tokenHandler.ReadJwtToken(Request.Query["Token"]);
            var readToken = tokenHandler.ReadJwtToken(Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty));
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value; //email client

            var foundClient = context.Users.Where(user => user.Email == getEmail).FirstOrDefault();

            var dbparams = new DynamicParameters();
            dbparams.Add("candidateId", interviewRequestVM.CandidateId, DbType.Int32);
            dbparams.Add("userId", foundClient.Id, DbType.Int32);
            dbparams.Add("bidSalary", interviewRequestVM.BidSalary, DbType.Int64);
            dbparams.Add("schedule", interviewRequestVM.Schedule, DbType.DateTime);

            var result = Task.FromResult(_dapper.Insert<int>("[dbo].[SP_InsertInterviewRequest]", dbparams, commandType: CommandType.StoredProcedure));
            return Ok(new { result = result, message = "Interview Request has been sent." });
        }
    }
}
