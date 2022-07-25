using Microsoft.EntityFrameworkCore;
using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.DAO.ProductDAO
{
    public class ProductsDAO
    {
        public int getMaxProduct()
        {
            string sql = "select top 1 product_id, sum(quantity) as 'qt' from [order_detail] group by product_id order by qt desc";
            DataTable dt = DAOConnect.DBcontext.GetDataBySql(sql);
            DataRow dr = dt.Rows[0];
            return Convert.ToInt32(dr["product_id"]);
        }

        public List<int> getTopProduct()
        {
            List<int> i = new List<int>();
            string sql = "select top 4 product_id, sum(quantity) as 'qt' from [order_detail] group by product_id order by qt desc";
            DataTable dt = DAOConnect.DBcontext.GetDataBySql(sql);
            foreach(DataRow row in dt.Rows)
            {
                i.Add(Convert.ToInt32(row["product_id"]));
            }
            return i;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                products = context.Products
                    .Include(x => x.Feedbacks)
                    .Include(x => x.Category)
                    .ToList<Product>();
            }

                return products;
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                product = context.Products.FirstOrDefault(x => x.ProductId == id);
            }

            return product;
        }

        public void AddProduct(Product product)
        {
            if (product == null) return;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            if (product == null) return;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
        }
    }
}
