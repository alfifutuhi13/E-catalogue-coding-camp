using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public Client Client { get; set; }
        public User User { get; set; }
        public InterviewRequest InterviewRequest { get; set; }
    }
}
