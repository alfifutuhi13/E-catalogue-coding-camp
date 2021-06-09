using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InsertCVVM
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public List<OrganizationVM> Organizations { get; set; }
        public List<SkillVM> Skills { get; set; }
        public List<WorkVM> Works { get; set; }
    }

    public class OrganizationVM
    {
        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string RoleOrganization { get; set; }
    }
    public class SkillVM
    {
        public string SkillId { get; set; }
        public string SkillName { get; set; }
    }
    public class WorkVM
    {
        public string WorkId { get; set; }
        public string WorkName { get; set; }
    }
}

