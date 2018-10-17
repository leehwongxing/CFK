using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Order
    {
        [Required]
        public long Order_ID { get; set; }

        [MinLength(1, ErrorMessage = "OrdererName shouldn't be empty")]
        public string OrdererName { get; set; }

        [MinLength(1, ErrorMessage = "OrdererAddr shouldn't be empty")]
        public string OrdererAddr { get; set; }

        [MinLength(1, ErrorMessage = "ReceipentName shouldn't be empty")]
        public string ReceipentName { get; set; }

        [MinLength(1, ErrorMessage = "ReceipentAddr shouldn't be empty")]
        public string ReceipentAddr { get; set; }

        public string Note { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount can't be negative")]
        public double Discount { get; set; }

        public string DiscountNote { get; set; }

        public long Ref_Customer { get; set; }

        public long Ref_User { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't 0 or negative")]
        public long CreateAt { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "SentAt can't 0 or negative")]
        public long SentAt { get; set; }
    }
}
