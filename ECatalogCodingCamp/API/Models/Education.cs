using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_Education")]
    public class Education
    {
        public Education()
        {
            this.University = new University();
            this.Major = new Major();
            this.User = new User();
        }
        [Key]
        public int Id { get; set; }
        public string Degree { get; set; }
        public float GPA { get; set; }
        public Major Major { get; set; }
        public University University { get; set; }
        public User User { get; set; }
    }
}
