using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CVRepository : GeneralRepository<CV, MyContext, int>
    {
        private readonly MyContext myContext;

        public CVRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
