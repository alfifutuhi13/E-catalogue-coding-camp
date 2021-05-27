using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class SkillCVRepository : GeneralRepository<SkillCV, MyContext, int>
    {
        private readonly MyContext myContext;

        public SkillCVRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
