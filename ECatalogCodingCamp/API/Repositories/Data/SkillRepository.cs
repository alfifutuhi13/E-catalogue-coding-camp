using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class SkillRepository : GeneralRepository<Skill, MyContext, int>
    {
        private readonly MyContext myContext;

        public SkillRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
