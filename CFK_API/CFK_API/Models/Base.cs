using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public abstract class Base<T>
    {
        protected static HashSet<string> Properties { get; private set; }

        protected static HashSet<string> Excluded { get; set; }

        public string[] Remove { get { return Excluded.ToArray(); } }

        public HashSet<string> _Fields { get { return Properties; } }

        public Base()
        {
            Properties = new HashSet<string>();
            Excluded = new HashSet<string>();

            var type = GetType();
            foreach (var Property in type.GetProperties())
            {
                Properties.Add(Property.Name);
            }
        }

        public string Include(bool includeAll = false, params string[] fields)
        {
            HashSet<string> inputs;

            if (fields.Count() == 0)
            {
                inputs = new HashSet<string>(Properties);
            }
            else
            {
                inputs = new HashSet<string>(fields);

                inputs.IntersectWith(Properties);
            }

            if (!includeAll)
            {
                inputs.ExceptWith(Excluded);
            }

            return string.Join(", ", inputs);
        }
    }
}
