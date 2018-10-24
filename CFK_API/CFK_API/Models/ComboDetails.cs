namespace CFK_API.Models
{
    public class ComboDetails : Base<ComboDetails>
    {
        public int Combo_ID { get; set; }

        public int Product_ID { get; set; }

        public double SalePrice { get; set; }
    }
}
