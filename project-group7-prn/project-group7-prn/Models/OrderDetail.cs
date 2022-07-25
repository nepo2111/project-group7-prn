using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double? SalePrice { get; set; }
        public int? Stock { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int? CategoryId { get; set; }

        public virtual Order Order { get; set; }
    }
}
