using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Question1.Models
{
    public class Product
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Please Enter Product Name")]
        public string ProductName { get; set; }
        
        [Required(ErrorMessage = "Please Enter Product Price")]
        [DataType(DataType.Text)]
        public int ProductPrice { get; set; }
        [Required(ErrorMessage = "Please Enter Product Description")]
        [MinLength(5), MaxLength(20)]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Please Enter Product Image")]
        public string ProductImage { get; set; }
        [Required(ErrorMessage = "Please Enter Product Date")]
        [DataType(DataType.Date)]
        public DateTime ProductAddedDate { get; set; }

        //Foreign Key Column
        public int BrandId { get; set; }

        public int CategoryId { get; set; }
        //Navigation Property
        public Category Category { get; set; }
        public Brand Brand { get; set; }


    }
}