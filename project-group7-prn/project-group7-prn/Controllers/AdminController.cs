using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using project_group7_prn.DAO;
using project_group7_prn.DAO.ProductDAO;
using project_group7_prn.Models;
using project_group7_prn.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace project_group7_prn.Controllers
{
    public class AdminController : Controller
    {
        private IHostingEnvironment Environment;

        public AdminController(IHostingEnvironment environment)
        {
            Environment = environment;
        }

        //public IActionResult Dashboard()
        //{
        //    return View();
        //}

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
        public IActionResult EditUser(IFormCollection result, User user, List<IFormFile> postedFiles)
        {

            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Individual/User/Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                user.Avatar = fileName;
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                }
            }
            
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

        public IActionResult AddNewUser()
        {
            User user = new User();
            user.Avatar = Security.AVATAR_DEFAULT;
            user.Role = Security.ROLE_CUSTOMER;
            user.Active = true;

            return View(user);
        }

        [HttpPost]
        public IActionResult AddNewUser(IFormCollection result, User user, List<IFormFile> postedFiles)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Individual/User/Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                user.Avatar = fileName;
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                }
            }

            string gender = result["rdGender"];
            user.Gender = bool.Parse(gender);
            UserDAO uDao = new UserDAO();
            User userOld = null;
            userOld = uDao.GetUserByEmail(user.Email);
            if (userOld == null)
            {
                uDao.AddUser(user);
                User userNew = uDao.GetUserByEmail(user.Email);
                ViewData["mess"] = "Add user successfully!";
            }else
            {
                ViewData["messF"] = "This email has been registered. Please try again!";
            }

            return View(user);
        }

        public IActionResult Orders()
        {
            OrderDAO or = new OrderDAO();
            ViewData["orders"] = or.GetAllOrder();

            return View();
        }

        public IActionResult Products()
        {
            ProductsDAO pDao = new ProductsDAO();
            ViewData["products"] = pDao.GetProducts();


            return View();
        }


        public IActionResult EditProduct(int productId)
        {
            onlineShopSWPContext context = new onlineShopSWPContext();
            CategoryDAO cDao = new CategoryDAO();
            ProductsDAO pDao = new ProductsDAO();
            Product product = pDao.GetProductById(productId);
            ViewData["categories"] = new SelectList(context.Categories, "Id", "Name");

            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product, List<IFormFile> postedFiles)
        {
            onlineShopSWPContext context = new onlineShopSWPContext();

            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Individual/User/Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                product.Img = fileName;
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                }
            }

            ProductsDAO pDao = new ProductsDAO();
            pDao.UpdateProduct(product);
            Product productNew = pDao.GetProductById(product.ProductId);
            ViewData["mess"] = "Successfully updated!";
            ViewData["categories"] = new SelectList(context.Categories, "Id", "Name");



            return View(productNew);
        }

        public void ChangeActiveProduct(int pid, string status)
        {
            ProductsDAO pDao = new ProductsDAO();
            Product product = pDao.GetProductById(pid);
            product.Active = Convert.ToInt32(status);
            pDao.UpdateProduct(product);

        }

        public void Delete(int productId)
        {
            onlineShopSWPContext context = new onlineShopSWPContext();
            ProductsDAO pDao = new ProductsDAO();
            Product product = pDao.GetProductById(productId);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }

        }



        public IActionResult AddNewProduct()
        {
            onlineShopSWPContext context = new onlineShopSWPContext();
            CategoryDAO cDao = new CategoryDAO();
            ProductsDAO pDao = new ProductsDAO();
            Product product = new Product();
            product.Active = 1;
            product.AuthorId = 1;
            product.CreateDate = DateTime.Now;
            ViewData["categories"] = new SelectList(context.Categories, "Id", "Name");

            return View(product);
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product, List<IFormFile> postedFiles)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Individual/User/Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                product.Img = fileName;
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                }
            }
            onlineShopSWPContext context = new onlineShopSWPContext();
            ProductsDAO pDao = new ProductsDAO();
            pDao.AddProduct(product);
            ViewData["mess"] = "New product added successfully!";
            ViewData["categories"] = new SelectList(context.Categories, "Id", "Name");

            return View(product);
        }
    }
}
