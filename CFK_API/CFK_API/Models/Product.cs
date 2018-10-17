using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Product
    {
        public int Product_ID { get; set; }

        public int Cate_ID { get; set; }

        public string ProductName { get; set; }

        public string BarNumber { get; set; }

        public string ProductTag { get; set; }

        public double BasePrice { get; set; }

        public double SalePrice { get; set; }

        public float VAT { get; set; }

        public string Origin { get; set; }

        public string Content { get; set; }

        public string Preview { get; set; }

        public string Properties { get; set; }

        public bool IsCombo { get; set; }

        public long CreatedAt { get; set; }

        public long Ref_User { get; set; }
    }
}
