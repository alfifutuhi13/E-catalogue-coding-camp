﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_University")]
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
