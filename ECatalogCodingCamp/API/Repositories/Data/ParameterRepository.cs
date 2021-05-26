using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class ParameterRepository : GeneralRepository<Parameter, MyContext, int>
    {
        private readonly MyContext myContext;

        public ParameterRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
