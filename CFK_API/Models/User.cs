using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class User
    {
        [Range(-1, int.MaxValue)]
        public int User_ID { get; set; }

        [Required]
        [MinLength(1)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public string ResetToken { get; set; }

        public bool IsLocked { get; set; }

        [Range(1, long.MaxValue)]
        public long CreatedAt { get; set; }

        [Range(1, int.MaxValue)]
        public long CreatedBy { get; set; }

        public User()
        {
            CreatedAt = Compute.Time.UnixNow;
            IsLocked = false;
        }
    }
}