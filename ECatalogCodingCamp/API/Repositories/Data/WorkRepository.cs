using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class WorkRepository : GeneralRepository<Work, MyContext, int>
    {
        private readonly MyContext myContext;

        public WorkRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
