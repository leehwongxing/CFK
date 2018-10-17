using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models.Outputs
{
    public class User_Signed_In : Base
    {
        public Projections.Token Data { get; set; }

        public User_Signed_In() : base()
        {
            Data = new Projections.Token();
        }
    }
}
