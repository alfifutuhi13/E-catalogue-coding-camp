using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class EducationRepository : GeneralRepository<Education, MyContext, int>
    {
        private readonly MyContext context;

        public EducationRepository(MyContext context) : base(context)
        {
            this.context = context;
        }
        public Education GetEducationId(int id)
        {
            var get = context.Educations
                .Include(e => e.Major).ThenInclude(m => m.Name)
                .Include(e => e.University).ThenInclude(u => u.Name)
                .FirstOrDefault(e => e.Id == id);
            return get;
        }

        public IEnumerable<Education> GetAllEducation()
        {
            var get = context.Educations
                .Include(e => e.Major).ThenInclude(m => m.Name)
                .Include(e => e.University).ThenInclude(u => u.Name);
            return get;
        }
    }
}
