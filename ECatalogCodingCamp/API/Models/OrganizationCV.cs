using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_OrganizationCV")]
    public class OrganizationCV
    {
        public int Id { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Organization> Organizations { get; set; }

    }
}
