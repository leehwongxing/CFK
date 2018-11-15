using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Address : Base<Address>
    {
        public long Address_ID { get; set; }
        public long Customer_ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string StreetDetails { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public int Priority { get; set; }
        public long CreatedAt { get; set; }

        public Address() : base()
        {
            Address_ID = -1;
            Customer_ID = -1;
            FullName = "";
            Phone = "";
            StreetDetails = "";
            Ward = "";
            District = "";
            Province = "";
            Priority = 1;
            CreatedAt = Compute.Time.UnixNow;

            Excluded = new HashSet<string> { "Customer_ID" };
        }
    }
}
