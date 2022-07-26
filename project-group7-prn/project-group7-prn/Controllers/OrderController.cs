using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;
using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int page)
        {
            using (var db = new onlineShopSWPContext())
            {
                if (page == 0) page = 1;
                //suawr
                int Uid = 0;
                if(HttpContext.Session.GetString("userID") != null)
                {
                    Uid = int.Parse(HttpContext.Session.GetString("userID"));
                } else
                {
                    return Redirect("/Home/Login");
                }
                
                int pageSize = db.Orders.Where(o => o.UserId == Uid).Count();

                int size = pageSize / 3;
                if (pageSize % 3 != 0)
                {
                    size++;
                }

                ViewBag.Size = size;
                ViewBag.Order = db.Orders.Where(o => o.UserId ==  Uid).ToList().ToPagedList(page, 3);
                ViewBag.pageNumber = page;
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(int Uid, int page)
        //{
        //    using (var db = new onlineShopSWPContext())
        //    {
        //        //suawr
        //        Uid = 1;
        //        ViewBag.Order = db.Orders.Where(p => p.UserId == (Uid == 0 ? p.UserId : Uid)).ToList().Take(3);
        //    }
        //    return View();
        //}

        [HttpPost]
        public JsonResult OrderDetail(int orderId)
        {
            using (var db = new onlineShopSWPContext())
            {
                //ViewBag.product = db.OrderDetails.Where(o => o.OrderId == orderId).ToList();
                //List<OrderDetail> orderDetails = db.OrderDetails.Where(o => o.OrderId == orderId).ToList();
                return Json(db.OrderDetails.Where(o => o.OrderId == orderId).ToList());
            }
        }
    }
}
