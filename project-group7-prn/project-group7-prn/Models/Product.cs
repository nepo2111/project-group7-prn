using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class Product
    {
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public int? BrandId { get; set; }
        public double Price { get; set; }
        public double? SalePrice { get; set; }
        public int? Stock { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int AuthorId { get; set; }
        public int? Active { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
