using Microsoft.EntityFrameworkCore;
using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.DAO
{
    public class OrderDAO
    {

        public List<Order> GetAllOrder()
        {
            List<Order> orders = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                orders = context.Orders
                    .Include(x => x.OrderDetails)
                    .Include(x => x.User)
                    .ToList<Order>();
            }
                return orders;
        }
    }
}
