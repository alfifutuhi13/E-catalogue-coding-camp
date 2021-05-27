using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class OrganizationCVRepository : GeneralRepository<OrganizationCV, MyContext, int>
    {
        private readonly MyContext myContext;

        public OrganizationCVRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
