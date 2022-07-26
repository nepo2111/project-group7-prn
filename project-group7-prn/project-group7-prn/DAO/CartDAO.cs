using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_group7_prn.Models;

namespace project_group7_prn.DAO
{
    public class CartDAO
    {
        public List<CartDetail> GetCartDetails(int cartId)
        {
            List<CartDetail> lstCartD = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                lstCartD = context.CartDetails.Where(x => x.CartId == cartId).ToList<CartDetail>();
            }

                return lstCartD;
        }
    }
}
