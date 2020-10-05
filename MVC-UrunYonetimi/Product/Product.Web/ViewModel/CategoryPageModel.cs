using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product.Web.ViewModel
{
    public class CategoryPageModel
    {
        public Category CurrentCategory { get; set; }
        public List<Category> CategoryList { get; set; }
        public List<Products> ProductList { get; set; }
    }
}