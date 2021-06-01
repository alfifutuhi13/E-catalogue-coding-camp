using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Organization")]
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleOrganization { get; set; }
        public ICollection<OrganizationCV> OrganizationCVs { get; set; }
    }
}
