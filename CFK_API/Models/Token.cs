using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Token
    {
        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Token_ID can't be 0 or negative number")]
        public long Token_ID { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "User_ID can't be 0 or negative number")]
        public int User_ID { get; set; }

        public string Content { get; set; }

        [Required]
        public string Origin { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't be 0 or negative number")]
        public long CreatedAt { get; set; }

        public Token()
        {
            CreatedAt = Compute.Time.UnixNow;
        }
    }
}
