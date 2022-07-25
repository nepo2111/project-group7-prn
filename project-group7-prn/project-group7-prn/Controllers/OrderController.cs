using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int Uid)
        {
            using (var db = new onlineShopSWPContext())
            {
                //suawr
                Uid = 1;
                ViewBag.Order = db.Orders.Where(p => p.UserId == (Uid == 0 ? p.UserId : Uid)).ToList().Take(3);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Uid, int page)
        {
            using (var db = new onlineShopSWPContext())
            {
                //suawr
                Uid = 1;
                ViewBag.Order = db.Orders.Where(p => p.UserId == (Uid == 0 ? p.UserId : Uid)).ToList().Take(3);
            }
            return View();
        }

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
