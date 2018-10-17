using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Role
    {
        [Required(ErrorMessage = "Role_ID mustn't be empty")]
        [MinLength(1)]
        [MaxLength(16, ErrorMessage = "Role_ID's length can't be longer than 16 chars")]
        public string Role_ID { get; set; }

        [Required(ErrorMessage = "RoleName mustn't be empty")]
        [MinLength(0)]
        [MaxLength(128, ErrorMessage = "RoleName's length can't be longer than 128 chars")]
        public string RoleName { get; set; }

        public bool IsGlobal { get; set; }

        public Role()
        {
            Role_ID = "";
            RoleName = "";
            IsGlobal = false;
        }
    }
}
