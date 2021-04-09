using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Third.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }//FK
        //navigation proprety 
        public Category Category { get; set; }

        public decimal Price { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
         

    }
}