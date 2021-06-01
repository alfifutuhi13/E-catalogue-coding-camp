using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_InterviewRequest")]
    public class InterviewRequest
    {
        [Key]
        public int Id { get; set; }
        public long BidSalary { get; set; }
        public DateTime Schedule { get; set; }
        public Book Book { get; set; }
    }
}
