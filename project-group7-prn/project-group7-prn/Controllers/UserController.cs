using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_group7_prn.Models;
using project_group7_prn.Services;
using project_group7_prn.DAO;


namespace project_group7_prn.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            //Set inf for user customer
            user.Role = Security.ROLE_CUSTOMER;
            user.Active = true;
            user.Avatar = Security.AVATAR_DEFAULT;

            UserDAO userDAO = new UserDAO();
            userDAO.AddUser(user);
            ViewData["mess"] = "Successful account registration. You can login now!";
            

            return View();
        }

        


    }
}
