namespace CFK_API.Models
{
    public class UserToken
    {
        public long Token_ID { get; set; }
        public int User_ID { get; set; }
        public string Content { get; set; }
        public string Origin { get; set; }
        public long CreatedAt { get; set; }

        public UserToken()
        {
            CreatedAt = Compute.Time.UnixNow;
        }
    }
}
