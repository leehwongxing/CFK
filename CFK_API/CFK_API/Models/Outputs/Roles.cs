using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models.Outputs
{
    public class RoleMsg : Base
    {
        public new IEnumerable<Role> Data { get; set; }

        public RoleMsg()
        {
            Data = new List<Role>();
        }
    }
}
