using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class JobRoleRepository : GeneralRepository<JobRole, MyContext, int>
    {
        private readonly MyContext myContext;

        public JobRoleRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
