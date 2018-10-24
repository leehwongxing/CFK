using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Category : Base<Category>
    {
        public int Cat_ID { get; set; }
        public string CatName { get; set; }
        public long CreatedAt { get; set; }
        public long Ref_User { get; set; }

        public Category() : base()
        {
            Cat_ID = -1;
            CatName = "";
            CreatedAt = Compute.Time.UnixNow;
            Ref_User = -1;
        }
    }
}
