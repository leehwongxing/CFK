using System.ComponentModel.DataAnnotations;

namespace CFK_API.Models
{
    public class Image : Base<Image>
    {
        [Range(0, long.MaxValue, ErrorMessage = "Image_ID không thể là số âm")]
        public long Image_ID { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Size phải là số dương")]
        public long FileSize { get; set; }

        [MinLength(1, ErrorMessage = "Ảnh không xác định được MIME")]
        public string MIME { get; set; }

        [MinLength(0, ErrorMessage = "SavedAt không thể trống")]
        public string SavedAt { get; set; }

        public string MirroredAt { get; set; }

        public string Content { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "CreatedAt không thể là số âm")]
        public long CreatedAt { get; set; }

        public long Ref_User { get; set; }

        public long Ref_Customer { get; set; }

        public Image() : base()
        {
            Image_ID = 0;
            FileSize = -1;
            MIME = "";
            SavedAt = "";
            MirroredAt = "";
            Content = "";
            CreatedAt = Compute.Time.UnixNow;
            Ref_Customer = -1;
            Ref_User = -1;
        }
    }
}
