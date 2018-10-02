namespace CFK_API.Models
{
    public class Token
    {
        public long Token_ID { get; set; }
        public int User_ID { get; set; }
        public string Content { get; set; }
        public string Origin { get; set; }
        public long CreatedAt { get; set; }

        public Token()
        {
            CreatedAt = Compute.Time.UnixNow;
        }
    }
}
