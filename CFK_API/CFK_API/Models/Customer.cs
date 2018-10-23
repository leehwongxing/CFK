using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Customer : Base<Customer>
    {
        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Customer_ID can't be 0 or negative")]
        public long Customer_ID { get; set; }

        [Required]
        [RegularExpression("[\\p{L}\\s]+", ErrorMessage = "Username only support Latin characters")]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email must be a valid email address")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Password should be longer, like 10 chars at least")]
        public string Password { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Fullname mustn't be empty")]
        public string FullName { get; set; }

        public byte Gender { get; set; }

        [Required]
        [RegularExpression("\\d{2}-\\d{2}-\\d{4}", ErrorMessage = "Birthday must be in 'dd-mm-yyyy format'")] // dd-mm-yyyy format
        public string Birthday { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public long VerifiedAt { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't be 0 or negative")]
        public long CreatedAt { get; set; }

        public string Ref_Avatar { get; set; }

        public string Ref_Profile { get; set; }

        public bool IsLocked { get; set; }
    }
}
