﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProiectAnaliza.Models
{
    public class Product : BaseEntity
    {
        
        
        [StringLength(20)]
        [DisplayName("Nume produs")]
        public string Name { get; set; }

        public string Description { get; set; }
        
        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        
    }
}