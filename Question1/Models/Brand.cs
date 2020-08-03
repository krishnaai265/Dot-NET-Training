﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Question1.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public DateTime BrandAddedDate { get; set; }

        //Navigation Property
        public List<Product> Products { get; set; }
    }
}