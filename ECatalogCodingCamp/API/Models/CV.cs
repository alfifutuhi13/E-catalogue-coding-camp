using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_CV")]
    public class CV
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public OrganizationCV OrganizationCV { get; set; }
        public SkillCV SkillCV { get; set; }
        public WorkCV WorkCV { get; set; }
        public User User { get; set; }
    }
}
