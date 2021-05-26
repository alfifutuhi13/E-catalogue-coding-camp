using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_InterviewRequest")]
    public class InterviewRequest
    {
        public int Id { get; set; }
        public long BidSalary { get; set; } //long int
        public string Email { get; set; }
    }
}
