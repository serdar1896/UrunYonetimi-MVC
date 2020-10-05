using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product.Admin.ViewModel
{
    public class ProductFeaturePageModel
    {
        public IEnumerable<ProductFeature> ProductFeatureList { get; set; }
        public Products Products { get; set; }
        public ProductFeature ProductFeature { get; set; }
        
    }
}