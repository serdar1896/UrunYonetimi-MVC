using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Product.Data.Model
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureId { get; set; }
        [Required(ErrorMessage = "{0} Bos gecilmez")]
        [DisplayName("Ozellik Adi")]
        public string FeatureName { get; set; }
        [Required(ErrorMessage = "{0} Bos gecilmez")]
        [DisplayName("Ozellik Degeri")]
        public string FeatureValue { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Products Products { get; set; }

    }
}
