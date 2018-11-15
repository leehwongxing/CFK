using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Order : Base<Order>
    {
        [Range(0, long.MaxValue, ErrorMessage = "Order_ID không được là số âm")]
        public long Order_ID { get; set; }

        public string OrdererName { get; set; }

        public string OrdererAddr { get; set; }

        public string ReceipentName { get; set; }

        public string ReceipentAddr { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total không được là số âm")]
        public double Total { get; set; }

        public string Note { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount không được là số âm")]
        public double Discount { get; set; }

        public string DiscountNote { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Ref_Customer không được là số âm")]
        public long Ref_Customer { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Ref_User không được là số âm")]
        public long Ref_User { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Ref_Store không được là số âm")]
        public int Ref_Store { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt phải là số dương")]
        public long CreateAt { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "SentAt không được là số âm")]
        public long SentAt { get; set; }

        public Order() : base()
        {
            Order_ID = 0;
            OrdererName = "";
            OrdererAddr = "";
            ReceipentAddr = "";
            ReceipentName = "";
            Total = 0;
            Note = "";
            Discount = 0;
            DiscountNote = "";
            Ref_Customer = -1;
            Ref_User = 0;
            Ref_Store = 0;
            CreateAt = Compute.Time.UnixNow;
            SentAt = 0;
        }
    }
}
