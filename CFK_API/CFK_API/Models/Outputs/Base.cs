using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models.Outputs
{
    public class Base
    {
        public int _Code { get; set; }

        public IList<string> _Messages { get; set; }

        public Object _Metadata { get; set; }

        public string _ResourceName { get; set; }

        public Base()
        {
            _Metadata = new object();
            _Messages = new List<string>();
        }
    }
}
