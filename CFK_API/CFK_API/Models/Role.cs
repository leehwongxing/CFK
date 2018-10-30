using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Role : Base<Role>
    {
        [Required]
        [MinLength(1, ErrorMessage = "Role_ID không được bỏ trống")]
        [MaxLength(16, ErrorMessage = "Role_ID không dài hơn 16 kí tự")]
        public string Role_ID { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "RoleName không được bỏ trống")]
        [MaxLength(128, ErrorMessage = "RoleName không dài hơn 128 kí tự")]
        public string RoleName { get; set; }

        public bool IsGlobal { get; set; }

        public Role() : base()
        {
            Role_ID = "";
            RoleName = "";
            IsGlobal = false;
        }
    }
}
