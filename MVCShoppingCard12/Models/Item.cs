﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShoppingCard12.Models
{
    public class Item
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}