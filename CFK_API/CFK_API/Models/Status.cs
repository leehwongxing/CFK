using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Models
{
    public class Status : Base<Status>
    {
        [Required]
        [MinLength(1, ErrorMessage = "Status_ID không được để trống")]
        public string Status_ID { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Priority không được là số âm")]
        public int Priority { get; set; }

        public Status() : base()
        {
            Status_ID = "";
            Priority = 0;
        }
    }
}
