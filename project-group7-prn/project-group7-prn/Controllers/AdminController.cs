using Microsoft.AspNetCore.Mvc;
using project_group7_prn.DAO;
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
