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
        public CV CV { get; set; }
        public Organization Organization { get; set; }

    }
}
