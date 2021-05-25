﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Parameter")]
    public class Parameter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
