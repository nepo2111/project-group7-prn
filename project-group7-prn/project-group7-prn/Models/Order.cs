using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Total { get; set; }
        public int? Status { get; set; }
        public bool? Active { get; set; }
        public string Notes { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
