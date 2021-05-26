using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class InterviewRequestRepository : GeneralRepository<InterviewRequest, MyContext, int>
    {
        private readonly MyContext myContext;

        public InterviewRequestRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
