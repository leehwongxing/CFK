using System.Collections.Generic;

namespace CFK_API.Models
{
    public class UserExt : User
    {
        public HashSet<string> Roles { get; set; }

        public long Store_ID { get; set; }

        public string Role { get; set; }

        public UserExt()
        {
            Roles = new HashSet<string>();
            Store_ID = -1;
            Role = "";
        }

        public bool IsOnGlobalScope()
        {
            return Store_ID == -1 ? true : false;
        }
    }
}