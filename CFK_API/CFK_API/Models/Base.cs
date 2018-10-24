using System.Collections.Generic;
using System.Linq;

namespace CFK_API.Models
{
    public abstract class Base<T>
    {
        public static HashSet<string> Excluded { get; protected set; }

        public static IList<string> Fields { get; protected set; }

        static Base()
        {
            Fields = new List<string>();
            Excluded = new HashSet<string>();
        }

        public Base()
        {
            Fields = GetFields();
        }

        public IList<string> GetFields()
        {
            var fields = GetType().GetProperties();
            var result = new List<string>();

            foreach (var field in fields)
            {
                result.Add(field.Name);
            }

            return result;
        }

        public IList<string> SelectFields(bool includeAll = false, params string[] fields)
        {
            IList<string> outputs;

            if (fields.Count() == 0)
            {
                outputs = new List<string>(Fields);
            }
            else
            {
                outputs = new List<string>(fields);

                outputs = outputs.Intersect(Fields).ToList();
            }

            if (!includeAll)
            {
                outputs = outputs.Except(Excluded).ToList();
            }

            return outputs;
        }
    }
}
