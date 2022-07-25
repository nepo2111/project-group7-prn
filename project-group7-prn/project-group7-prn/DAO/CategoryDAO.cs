using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.DAO
{
    public class CategoryDAO
    {
        public List<Category> GetCategorys()
        {
            List<Category> categories = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                categories = context.Categories
                    .ToList<Category>();
            }
            return categories;

        }
    }
}
