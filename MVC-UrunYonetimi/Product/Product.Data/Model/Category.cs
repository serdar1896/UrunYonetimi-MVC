using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Product.Data.Model
{
    public class Category
    { 
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="{0} Bos gecilmez")]
        [DisplayName("Kategori Adi")]
        public string CategoryName { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
