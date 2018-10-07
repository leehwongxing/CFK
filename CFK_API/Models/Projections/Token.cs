using System;

namespace CFK_API.Models.Projections
{
    public class Token
    {
        public long Ref_SID { get; set; }

        public string FullName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ValidUntil { get; set; }

        public string Content { get; set; }
    }
}
