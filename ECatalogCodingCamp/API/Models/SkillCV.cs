using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_SkillCV")]
    public class SkillCV
    {
        public int Id { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
