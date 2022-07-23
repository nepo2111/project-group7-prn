using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int? Rated { get; set; }
        public string FbContent { get; set; }
        public string Img { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public bool? Active { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
