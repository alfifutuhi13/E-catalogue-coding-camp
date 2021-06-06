using API.Context;
using API.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CandidateRepository : GeneralRepository<Candidate, MyContext, int>
    {
        private readonly MyContext myContext;
        private readonly IConfiguration configuration;

        public CandidateRepository(MyContext myContext ,IConfiguration configuration) : base(myContext)
        {
            this.configuration = configuration;
        }

        public IEnumerable<dynamic> GetCandidates()
        {
            var dbparams = new DynamicParameters();
            using IDbConnection db = new SqlConnection(configuration.GetConnectionString("MyConnection"));
            return db.Query<dynamic>("[dbo].[SP_GetCandidates]", dbparams, commandType: CommandType.StoredProcedure);
        }
    }
}
