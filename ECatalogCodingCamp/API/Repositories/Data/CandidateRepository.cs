using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CandidateRepository : GeneralRepository<Candidate, MyContext, int>
    {
        private readonly MyContext myContext;

        public CandidateRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
