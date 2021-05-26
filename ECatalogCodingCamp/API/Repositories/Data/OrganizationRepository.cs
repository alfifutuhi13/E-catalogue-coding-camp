using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class OrganizationRepository : GeneralRepository<Organization, MyContext, int>
    {
        private readonly MyContext myContext;

        public OrganizationRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}

