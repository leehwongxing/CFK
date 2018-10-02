using System;

namespace CFK_API.Models.Projections
{
    public class Token
    {
        public int User_ID { get; set; }

        public int Store_ID { get; set; }

        public string FullName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpireOn { get; set; }

        public string Content { get; set; }
    }
}
