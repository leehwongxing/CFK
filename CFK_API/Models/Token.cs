using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Token
    {
        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Token_ID can't be 0 or negative number")]
        public long Token_ID { get; set; }

        public string Content { get; set; }

        [Required]
        public string Origin { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't be 0 or negative number")]
        public long CreatedAt { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "VaildUntil can't be 0 or negative number")]
        public long ValidUntil { get; set; }

        public bool IsCustomer { get; set; }

        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Ref_SID can't be 0 or negative number")]
        public long Ref_SID { get; set; }

        public Token()
        {
            CreatedAt = Compute.Time.UnixNow;
        }
    }
}
