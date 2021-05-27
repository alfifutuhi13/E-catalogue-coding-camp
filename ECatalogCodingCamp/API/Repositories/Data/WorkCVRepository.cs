using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class WorkCVRepository : GeneralRepository<WorkCV, MyContext, int>
    {
        private readonly MyContext myContext;

        public WorkCVRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
