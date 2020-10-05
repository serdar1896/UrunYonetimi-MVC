using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Product.Data.Model
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "{0} Bos gecilmez")]
        [DisplayName("Urun Adi")]
        public string ProductName { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }
        [Required]
      
        public int CategoryId { get; set; }
        [DisplayName("Kategori Adi")]
        public virtual Category Category { get; set; }
    }
}
