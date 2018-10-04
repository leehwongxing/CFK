using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class User
    {
        [Required]
        [Range(-1, int.MaxValue, ErrorMessage = "User_ID can't be 0 or negative")]
        public int User_ID { get; set; }

        [Required]
        [RegularExpression("[\\p{L}\\s]+", ErrorMessage = "Username only support Latin characters")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Fullname mustn't be empty")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email must be a valid email address")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Password should be longer, like 10 chars at least")]
        public string Password { get; set; }

        public long VerifiedAt { get; set; }

        public bool IsLocked { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't be 0 or negative")]
        public long CreatedAt { get; set; }

        [Range(1, int.MaxValue)]
        public long Ref_User { get; set; }

        public User()
        {
            CreatedAt = Compute.Time.UnixNow;
            IsLocked = false;
        }
    }
}
