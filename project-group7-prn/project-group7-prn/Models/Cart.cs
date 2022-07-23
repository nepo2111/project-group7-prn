using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartDetails = new HashSet<CartDetail>();
        }

        public int CartId { get; set; }
        public int UserId { get; set; }
        public double? TotalPrice { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
