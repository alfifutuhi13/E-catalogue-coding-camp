using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class RegisterClientVM
    {
        [Required(ErrorMessage = "Name should not be empty"), MaxLength(255, ErrorMessage = "Maximum 255 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email should not be empty"), EmailAddress(ErrorMessage = "Please input the valid email format"), MaxLength(255, ErrorMessage = "Maximum 255 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password should not be empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Phone Number should not be empty"), RegularExpression(@"^[08][0-9]{10,11}$", ErrorMessage = "This field should be numbers, start with '08'"), MinLength(11, ErrorMessage = "Minimum 11 characters")]
        public string Phone { get; set; }
    }
}
