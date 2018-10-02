using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Role
    {
        [Required]
        [MaxLength(16)]
        public string Role_ID { get; set; }

        [MaxLength(128)]
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
