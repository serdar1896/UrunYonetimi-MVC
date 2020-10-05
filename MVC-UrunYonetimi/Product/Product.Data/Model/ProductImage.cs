using System.ComponentModel.DataAnnotations;

namespace Product.Data.Model
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Products Products { get; set; }
    }
}
