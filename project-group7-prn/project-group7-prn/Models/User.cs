using System;
using System.Collections.Generic;

#nullable disable

namespace project_group7_prn.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? Role { get; set; }
        public bool? Active { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
