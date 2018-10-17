using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models.Projections
{
    public class Registry
    {
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

        [RegularExpression("\\d{2}-\\d{2}-\\d{4}", ErrorMessage = "Birthday must be in 'dd-mm-yyyy format'")] // dd-mm-yyyy format
        public string Birthday { get; set; }

        [Phone]
        public string Phone { get; set; }

        public Registry()
        {
            Birthday = "01-01-2000";
            Phone = "";
        }
    }
}
