using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Skill")]
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CV> CVs { get; set; }
        public SkillCV SkillCV { get; set; }
    }
}
