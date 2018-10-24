using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Customer : Base<Customer>
    {
        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Customer_ID không thể là số âm")]
        public long Customer_ID { get; set; }

        [Required]
        [RegularExpression("[\\p{L}\\s]+", ErrorMessage = "Username chỉ hỗ trợ chữ cái Latin")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Fullname không được bỏ trống")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email phải theo định dạng của Email")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Password tối thiểu 10 kí tự")]
        public string Password { get; set; }

        public byte Gender { get; set; }

        [Required]
        [RegularExpression("\\d{2}-\\d{2}-\\d{4}", ErrorMessage = "Birthday phải có dạng 'dd-mm-yyyy'")] // dd-mm-yyyy format
        public string Birthday { get; set; }

        public string Phone { get; set; }

        public long VerifiedAt { get; set; }

        public bool IsLocked { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt không thể là số âm")]
        public long CreatedAt { get; set; }

        public string Ref_Avatar { get; set; }

        public string Ref_Profile { get; set; }

        public Customer() : base()
        {
            Customer_ID = -1;
            Username = "";
            Email = "";
            Password = "";
            FullName = "";
            Gender = 0;
            Birthday = "";
            Phone = "";
            VerifiedAt = -1;
            IsLocked = false;
            CreatedAt = Compute.Time.UnixNow;
            Ref_Avatar = "";
            Ref_Profile = "";

            Excluded = new HashSet<string> { "Password", "VerifiedAt" };
        }
    }
}
