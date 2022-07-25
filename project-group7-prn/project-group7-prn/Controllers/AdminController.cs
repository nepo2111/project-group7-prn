using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_group7_prn.DAO;
using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult UserList()
        {
            UserDAO uDao = new UserDAO();
            ViewData["users"] = uDao.GetUsers();


            return View();
        }

        public IActionResult EditUser(string email)
        {
            UserDAO uDao = new UserDAO();
            User user = uDao.GetUserByEmail(email);

            return View(user);
        }

        [HttpPost]
        public IActionResult EditUser(IFormCollection result, User user)
        {
            string gender = result["rdGender"];
            user.Gender = bool.Parse(gender);
            UserDAO uDao = new UserDAO();
            uDao.UpdateUser(user);
            User userNew = uDao.GetUserByEmail(user.Email);
            ViewData["mess"] = "Successfully updated!";

            return View(userNew);
        }

        public void ChangeActiveUser(int uid, string status)
        {
            UserDAO uDao = new UserDAO();
            User user = uDao.GetUserById(uid);
            user.Active = bool.Parse(status);
            uDao.UpdateUser(user);

        }

        public IActionResult Orders()
        {
            


            return View();
        }

        public IActionResult Products()
        {



            return View();
        }
    }
}
