using API.Base;
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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController : BaseController<Work, WorkRepository, int>
    {
        private readonly WorkRepository workRepository;
        private readonly IGenericDapper _dapper;
        public WorksController(WorkRepository workRepository, IGenericDapper dapper) : base(workRepository)
        {
            this.workRepository = workRepository;
            _dapper = dapper;
        }

        [HttpPost("InsertWork")]
        public ActionResult InsertWork(InsertCVVM cv) 
        {
            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", cv.Email, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsertCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            int[] arrWorks = new int[cv.Works.Count];

            for (int i = 0; i < cv.Works.Count; i++)
            {
                var paramsGetWorkId = new DynamicParameters();
                paramsGetWorkId.Add("Name", cv.Works[i].WorkName, DbType.String);
                var WorkId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_GetInsert_TB_M_Work]", paramsGetWorkId, commandType: CommandType.StoredProcedure));

                var paramsInsertWorkCV = new DynamicParameters();
                paramsInsertWorkCV.Add("CVId", CVId.Result, DbType.Int32);
                paramsInsertWorkCV.Add("WorkId", WorkId.Result, DbType.Int32);
                var workCV = _dapper.Insert<int>("[dbo].[SP_Insert_TB_T_WorkCV]", paramsInsertWorkCV, commandType: CommandType.StoredProcedure);

                arrWorks[i] = workCV;
            }

            return Ok(new { result = arrWorks }) ;
        }

        [HttpPut("UpdateWork")]
        public ActionResult UpdateWork(InsertCVVM cv) 
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
            var readToken = tokenHandler.ReadJwtToken(token);
            var getEmail = readToken.Claims.First(getEmail => getEmail.Type == "email").Value;

            var paramsGetCVId = new DynamicParameters();
            paramsGetCVId.Add("Email", getEmail, DbType.String);
            var CVId = Task.FromResult(_dapper.Get<int>("[dbo].[SP_RetrieveCVId]", paramsGetCVId, commandType: CommandType.StoredProcedure));

            var paramsGetWorkId = new DynamicParameters();
            paramsGetWorkId.Add("CVId", CVId.Result, DbType.Int32);
            var WorkId = _dapper.GetAll<int>("[dbo].[SP_RetrieveWorkId]", paramsGetWorkId, commandType: CommandType.StoredProcedure);


            int[] arrWorks = new int[cv.Works.Count];

            for (int i = 0; i < cv.Works.Count; i++)
            {
                var paramUpdateWork = new DynamicParameters();
                paramUpdateWork.Add("WorkId", WorkId[i], DbType.Int32);
                paramUpdateWork.Add("Name", cv.Works[i].WorkName, DbType.String);
                var queryWork = _dapper.Insert<int>("[dbo].[SP_Update_TB_M_Work]", paramUpdateWork, commandType: CommandType.StoredProcedure);

                arrWorks[i] = queryWork;
            }
            return Ok(new { result = arrWorks });
        }
    }
}