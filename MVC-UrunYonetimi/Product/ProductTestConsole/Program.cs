using Product.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ProductContext();
            var categoryList = context.Category.ToList();
        }
    }
}
