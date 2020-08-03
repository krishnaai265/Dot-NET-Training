using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC10.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public DateTime CategoryAddedDate { get; set; }

        //Navigation Property
        public List<Product> Products { get; set; }
    }
}