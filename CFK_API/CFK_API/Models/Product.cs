using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Product : Base<Product>
    {
        [Range(0, int.MaxValue, ErrorMessage = "Product_ID không được là số âm")]
        public int Product_ID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Cat_ID phải là số dương")]
        public int Cat_ID { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "ProductName không được để trống")]
        public string ProductName { get; set; }

        public string BarNumber { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "ProductTag không được bỏ trống")]
        public string ProductTag { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "BasePrice không được là số âm")]
        public double BasePrice { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "SalePrice không được là số âm")]
        public double SalePrice { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "VAT không được là số âm")]
        public float VAT { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Origin không được để trống")]
        public string Origin { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Content không được để trống")]
        public string Content { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Preview không được để trống")]
        public string Preview { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Properties không được để trống")]
        public string Properties { get; set; }

        public bool IsCombo { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "CreatedAt không được là số âm")]
        public long CreatedAt { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Ref_User không được là số âm")]
        public long Ref_User { get; set; }

        public Product() : base()
        {
            Product_ID = 0;
            Cat_ID = 0;
            ProductName = "";
            BarNumber = "";
            ProductTag = "";
            BasePrice = 0;
            SalePrice = 0;
            VAT = 0;
            Origin = "";
            Content = "";
            Preview = "";
            Properties = "";
            IsCombo = false;
            CreatedAt = Compute.Time.UnixNow;
            Ref_User = 0;
        }
    }
}
