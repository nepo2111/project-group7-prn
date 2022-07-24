using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_group7_prn.DAO;
using project_group7_prn.Models;
using project_group7_prn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new onlineShopSWPContext())
            {
                ViewBag.Product = db.Products.Include(p => p.Category).ToList().OrderByDescending(p => p.CreateDate).Take(6);

                var query = (from qa in db.Products
                             let tongSl = (from cthd in db.OrderDetails
                                           join hd in db.Orders on cthd.OrderId equals hd.OrderId
                                           where cthd.ProductId == qa.ProductId
                                           select cthd.Quantity
                                           ).Sum()
                             where tongSl > 0
                             orderby tongSl descending
                             select new
                             {
                                 qa.ProductId
                             }
                         ).Take(1);
                //ViewBag.BestSell = db.OrderDetails.Include(p => p.ProductId).Select(p => p.ProductId).
                ViewBag.BestSell = db.OrderDetails.Max(p => p.ProductId);
                ViewBag.Category = db.Categories.ToList();
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

       
        public void ResetPassword(string email)
        {
            UserDAO uDao = new UserDAO();
            User user = null;
            user = uDao.GetUserByEmail(email);
            if (user == null) throw new Exception();
            else
            {
                string newPassword = MailService.GetLetters(6);
                string mailbody = $"Hi {user.Fullname},<br><br>Congratulations<br><br>You have successfully reset your password, <br><br>your password is: " +
                    $"<b>" + newPassword + $"</b>" +
      $", regards<br><br>Administrator.";
                string subject = "RESET PASSWORD";
                MailService.SendMailMethod(email, mailbody, subject);
                user.Password = newPassword;
                uDao.UpdateUser(user);
            }

        }





    }
}
