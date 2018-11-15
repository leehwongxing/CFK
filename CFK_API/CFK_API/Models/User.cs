using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class User : Base<User>
    {
        [Required]
        [Range(-1, int.MaxValue, ErrorMessage = "User_ID không thể là số âm")]
        public int User_ID { get; set; }

        [Required]
        [RegularExpression("[\\p{L}\\s]+", ErrorMessage = "Username chỉ hổ trợ kí tự Latin")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Fullname không được bỏ trống")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email phải theo định dạng của email")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Password tối thiểu 10 kí tự")]
        public string Password { get; set; }

        public long VerifiedAt { get; set; }

        public bool IsLocked { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt không thể là số âm")]
        public long CreatedAt { get; set; }

        [Range(1, int.MaxValue)]
        public long Ref_User { get; set; }

        public User() : base()
        {
            CreatedAt = Compute.Time.UnixNow;
            IsLocked = false;
            Password = "";
            Username = "";
            FullName = "";
            Email = "";
            Ref_User = -1;
            VerifiedAt = -1;

            Excluded = new HashSet<string> { "User_ID", "Password", "VerifiedAt" };
        }
    }
}
