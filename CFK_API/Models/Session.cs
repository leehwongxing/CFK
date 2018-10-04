namespace CFK_API.Models
{
    public class Session
    {
        public long Session_ID { get; set; }

        public long Customer_ID { get; set; }

        public string Content { get; set; }

        public long CreatedAt { get; set; }

        public long ValidUntil { get; set; }
    }
}
