using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InsertCVVM
    {
        public List<Organization> Organizations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Work> Works { get; set; }
    }

    public class Organization
    {
        public string OrganizationName { get; set; }
        public string RoleOrganization { get; set; }
    }
    public class Skill
    {
        public string SkillName { get; set; }
    }
    public class Work
    {
        public string WorkName { get; set; }
    }
}

