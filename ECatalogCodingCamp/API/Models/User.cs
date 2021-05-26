using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field should not be empty"), MaxLength(255, ErrorMessage = "Maximum 255 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field should not be empty"), EmailAddress(ErrorMessage = "Please input the valid email format"), 
            MaxLength(255, ErrorMessage = "Maximum 255 characters")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public Education Education { get; set; }
        public JobRole JobRole { get; set; }
        public Participant Participant { get; set; }
        public Role Role { get; set; }
        public Account Account { get; set; }
    }
}
