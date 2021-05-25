using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Education Education { get; set; }
        public JobRole JobRole { get; set; }
        public Participant Participant { get; set; }
        public Role Role { get; set; }
    }
}
