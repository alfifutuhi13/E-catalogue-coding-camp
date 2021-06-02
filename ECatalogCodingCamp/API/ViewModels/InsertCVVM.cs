using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InsertCVVM
    {
        public List<OrganizationVM> Organizations { get; set; }
        public List<SkillVM> Skills { get; set; }
        public List<WorkVM> Works { get; set; }
    }

    public class OrganizationVM
    {
        public string OrganizationName { get; set; }
        public string RoleOrganization { get; set; }
    }
    public class SkillVM
    {
        public string SkillName { get; set; }
    }
    public class WorkVM
    {
        public string WorkName { get; set; }
    }
}

