using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class MajorRepository : GeneralRepository<Major, MyContext, int>
    {
        private readonly MyContext myContext;

        public MajorRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
