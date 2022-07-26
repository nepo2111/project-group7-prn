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

                ViewBag.BestSell = db.OrderDetails.Select(o => o.ProductId);
                ViewBag.Category = db.Categories.ToList();

                ViewBag.BestSell = db.Products.Find(new DAO.ProductDAO.ProductsDAO().getMaxProduct());

                List<int> i = new DAO.ProductDAO.ProductsDAO().getTopProduct();
                List<Product> plist = new List<Product>();

                foreach(int pid in i)
                {
                    plist.Add(db.Products.Find(pid));
                }

                ViewBag.BestSellTop = plist;
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

        [HttpPost]
        public IActionResult Login(IFormCollection result)
        {
            using (var db = new onlineShopSWPContext())
            {
                string email = result["mail"];
                string pass = result["password"];
                User u = db.Users.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(pass));
                if (u != null && u.Active==true)
                {
                    HttpContext.Session.SetString("userID", u.UserId.ToString());
                    if (u.Role == 2)
                    {
                        return Redirect("/Admin/UserList");
                    }else
                    {
                        return Redirect("/Home/Index");
                    }
                    
                }
                else
                    return Redirect("/Home/Login");
            }


        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("userID", "");
            return RedirectToAction(nameof(Login));
        }

        public IActionResult CartDetail()
        {
            int userId = 0;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                CartDAO cDao = new CartDAO();
                if (HttpContext.Session.GetString("userID") != null && HttpContext.Session.GetString("userID") != "")
                {
                    userId = Convert.ToInt32(HttpContext.Session.GetString("userID"));
                }
              
                if (userId != 0)
                {
                    Cart cart = context.Carts.FirstOrDefault(x => x.UserId == userId);
                    if (cart == null)
                    {
                        ViewData["cartDetails"] = null;
                        ViewData["mess"] = "There are no products in the cart.";
                    }else
                    {
                        List<CartDetail> lstCartDetail = cDao.GetCartDetails(cart.CartId);
                        ViewData["cartDetails"] = lstCartDetail;
                        ViewData["cart"] = cart;
                    }
                    return View();
                }
                else
                {
                    return RedirectToAction(nameof(Login));
                }
                
            }
                
            
            
        }


        public IActionResult addOrder(IFormCollection value)
        {
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                //int cartId = int.Parse(value["txtCartId"]);
                Cart cart = new Cart() { CartId = int.Parse(value["txtCartId"]) };
                List<CartDetail> lstDetail = context.CartDetails.Where(x => x.CartId == cart.CartId).ToList<CartDetail>();
                foreach(CartDetail c in lstDetail)
                {
                    context.CartDetails.Remove(c);
                    
                }
                context.Carts.Remove(cart);
                context.SaveChanges();

                //int userId = Convert.ToInt32(HttpContext.Session.GetString("userID"));
                //User user = context.Users.FirstOrDefault(u => u.UserId == userId);
                //Order order = new Order
                //{
                //    UserId = user.UserId,
                //    Fullname = user.Fullname,
                //    Address = user.Address,
                //    Phone = user.Phone,
                //    OrderDate = DateTime.Now.Date,
                //    Total = 0,
                //    Active = true,
                //    Notes = ""
                //};
                //context.Orders.Add(order);
                //context.SaveChanges();

                //OrderLast = context.

                return RedirectToAction(nameof(Index));
            }
        }

    }
}
