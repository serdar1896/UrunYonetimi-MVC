using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product.Web.ViewModel
{
    public class ProductPageModel
    {
        public Products CurrentProduct { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}