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
    }
}
