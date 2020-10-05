using Product.Data.Model;
using System;
using System.Web;
using System.Web.Mvc;

namespace Product.Admin.Helpers
{
    //Extension methodlar static
    public static class ImageHelper
    {
        public static IHtmlString Base64Image(this HtmlHelper helper, ProductImage productImage)
        {
            var imgString = string.Format(@"<img src='data:{0};base64,{1}' width='100' height='70' sr />",
                productImage.ContentType,
                Convert.ToBase64String(productImage.Content)
                );
            return new HtmlString(imgString);
        }

    }
}