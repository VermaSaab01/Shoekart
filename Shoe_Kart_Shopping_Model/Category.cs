﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model
{
    public class Category
    {
        public int id { get; set; }
        [Display(Name ="Shoe's Category")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
