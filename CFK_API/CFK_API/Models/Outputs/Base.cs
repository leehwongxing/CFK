using System;
using System.Collections.Generic;

namespace CFK_API.Models.Outputs
{
    public class Base
    {
        public int Code { get; set; }

        public long Version { get { return Compute.Time.Version; } }

        public IList<string> Errors { get; set; }

        public object Metadata { get; set; }

        public Base()
        {
            Metadata = new object();
            Errors = new List<string>();
            Code = 200;
        }
    }
}
