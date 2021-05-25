using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Participant")]
    public class Participant
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
