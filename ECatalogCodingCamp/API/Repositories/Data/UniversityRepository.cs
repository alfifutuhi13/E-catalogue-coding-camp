using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class UniversityRepository : GeneralRepository<University, MyContext, int>
    {
        private readonly MyContext myContext;

        public UniversityRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
