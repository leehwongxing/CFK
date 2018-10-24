using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Product : Base<Product>
    {
        [Range(0, int.MaxValue, ErrorMessage = "Product_ID ")]
        public int Product_ID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "")]
        public int Cat_ID { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string ProductName { get; set; }

        public string BarNumber { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string ProductTag { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "")]
        public double BasePrice { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "")]
        public double SalePrice { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "")]
        public float VAT { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string Origin { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string Content { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string Preview { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        public string Properties { get; set; }

        public bool IsCombo { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "")]
        public long CreatedAt { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "")]
        public long Ref_User { get; set; }

        public Product() : base()
        {
        }
    }
}
