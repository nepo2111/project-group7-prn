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
    public class ProductController : Controller
    {
        public IActionResult Index(int Cid, int Page)
        {
            using (var db = new onlineShopSWPContext())
            {
                ViewBag.Category = db.Categories.ToList();
                int pageNumber = 1;
                if(Page != 0)
                {
                    pageNumber = Page;
                }
                int pageSize = db.Products.Where(p => p.CategoryId == (Cid == 0 ? p.CategoryId : Cid)).Count();
                int size = pageSize/6;
                if (pageSize % 6 != 0)
                {
                    size++;
                }

                ViewBag.Size = size;
                ViewBag.Product = db.Products.Where(p => p.CategoryId == (Cid == 0?p.CategoryId:Cid)).ToList().ToPagedList(pageNumber, 6);
                if(Cid != 0){
                    ViewBag.Cid = Cid;
                }
                ViewBag.pageNumber = pageNumber;
                return View();
            }
        }
        public IActionResult Detail(int Pid)
        {
            using (var db = new onlineShopSWPContext())
            {
                ViewBag.Category = db.Categories.ToList();
                ViewBag.PDetail = db.Products.Find(Pid);
                ViewBag.FBack = db.Feedbacks.Include(f => f.Product).Include(f => f.User).Where(f => f.ProductId == Pid).ToList();
                ViewBag.countFBack = db.Feedbacks.Where(f => f.ProductId == Pid).Count();
            }
                return View();
        }
    }
}
