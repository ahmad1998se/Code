using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Third.Models;

namespace Third.ViewModels
{
    public class ProductFromViewModel
    {

        public Product Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }


    }
}