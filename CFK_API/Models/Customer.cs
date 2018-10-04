using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Customer
    {
        public long Customer_ID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ResetToken { get; set; }

        public long CreatedAt { get; set; }

        public string Phone_L1 { get; set; }

        public string Phone_L2 { get; set; }

        public string Addr_L1 { get; set; }

        public string Addr_L2 { get; set; }

        public bool IsLocked { get; set; }
    }
}
