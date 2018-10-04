using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Image
    {
        [Required(ErrorMessage = "Image_ID can't be empty")]
        public long Image_ID { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Size can't be 0 or negative")]
        public long Size { get; set; }

        [MinLength(1, ErrorMessage = "Image shouldn't have an empty MIME field")]
        public string MIME { get; set; }

        [MinLength(1, ErrorMessage = "SavedAt can't be empty")]
        public string SavedAt { get; set; }

        public string MirroredAt { get; set; }

        public string Content { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt can't be 0 or negative")]
        public long CreatedAt { get; set; }

        public long Ref_User { get; set; }

        public long Ref_Customer { get; set; }
    }
}
