﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Book")]
    public class Book
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public InterviewRequest InterviewRequest { get; set; }
    }
}