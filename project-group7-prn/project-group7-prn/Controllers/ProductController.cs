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
                // se thay bang sesson
                ViewBag.UserId = 1;
                ViewBag.Category = db.Categories.ToList();
                ViewBag.PDetail = db.Products.Find(Pid);
                ViewBag.FBack = db.Feedbacks.Include(f => f.Product).Include(f => f.User).Where(f => f.ProductId == Pid).ToList().Take(3);
                ViewBag.countFBack = db.Feedbacks.Where(f => f.ProductId == Pid).Count();
            }
                return View();
        }

        [HttpPost]
        public JsonResult viewFeedBack(int Id, int Pid)
        {
            using (var db = new onlineShopSWPContext())
            {
                //return Json(db.Feedbacks.ToList().Take(Id*3));
                ViewBag.fblist = db.Feedbacks.Include(f => f.Product).Include(f => f.User).Where(f => f.ProductId == Pid).ToList().Take(Id * 3);
                string data = "";
                foreach(Feedback fb in ViewBag.fblist)
                {
                    data += "<li data-content=\"television\" class=\"selected\">\n" +
                         "  <div class=\"comments-top-top\">\n" +
                            "   <div class=\"top-comment-left\">\n" +
                                "<img class=\"img-responsive\" src=" + fb.User.Avatar + " alt=\"\">\n" +
                            "   </div>\n" +
                            "   <div class=\"top-comment-right\" style=\"margin - bottom: 10px\">\n" +
                                "   <h6>" + fb.User.Fullname + " - " + (fb.FeedbackDate?.ToString("dd/MM/yyyy")) + "</h6>\n" +
                                "   <ul class=\"star-footer\">\n";
                            for(int i = 1; i <= fb.Rated; i++)
                            {
                                data += "   <li><i> </i></li>\n";
                            }
                            for (int i = (int)fb.Rated + 1; i <= 5; i++)
                            {
                                //data += "<li><i> </i></li>";
                            }
                    data += "   </ul>\n" +
                                "   \n<p>" + fb.FbContent + "</p>\n";
                    if(1 == fb.UserId)
                    {
                        data += " <div style=\"text-align: end\">\n" +
                                          "<a class=\"text-primary\">Edit</a> / <a class=\"text-danger\">Delete</a>\n"+
                                    "</div>\n";
                    }
                     data += " </div>\n"+
                          " </div>\n"+
                      "</li> \n";
                }
                return Json(data);
            }
        }

        [HttpPost]
        public JsonResult insertFeedBack(string fbContent, int rate, int pId, int id)
        {
            using (var db = new onlineShopSWPContext())
            {

                Feedback addfb = new Feedback { ProductId = pId, UserId = 1, Rated = rate, FbContent = fbContent, FeedbackDate = DateTime.Now.Date, Active = true, };
                db.Feedbacks.Add(addfb);
                db.SaveChanges();

                ViewBag.fblist = db.Feedbacks.Include(f => f.Product).Include(f => f.User).Where(f => f.ProductId == pId).ToList().Take(id*3).OrderByDescending(fb => fb.FeedbackId);
                string data = "";
                foreach (Feedback fb in ViewBag.fblist)
                {
                    data += "<li data-content=\"television\" class=\"selected\">\n" +
                         "  <div class=\"comments-top-top\">\n" +
                            "   <div class=\"top-comment-left\">\n" +
                                "<img class=\"img-responsive\" src=" + fb.User.Avatar + " alt=\"\">\n" +
                            "   </div>\n" +
                            "   <div class=\"top-comment-right\">\n" +
                                "   <h6>" + fb.User.Fullname + " - " + (fb.FeedbackDate?.ToString("dd/MM/yyyy")) + "</h6>\n" +
                                "   <ul class=\"star-footer\">\n";
                    for (int i = 1; i <= fb.Rated; i++)
                    {
                        data += "   <li><i> </i></li>\n";
                    }
                    for (int i = (int)fb.Rated + 1; i <= 5; i++)
                    {
                        //data += "<li><i> </i></li>";
                    }
                    data += "   </ul>\n" +
                                "   \n<p>" + fb.FbContent + "</p>\n";
                    if (1 == fb.UserId)
                    {
                        data += " <div style=\"text-align: end\">\n" +
                                          "<a class=\"text-primary\">Edit</a> / <a class=\"text-danger\">Delete</a>\n" +
                                    "</div>\n";
                    }
                    data += " </div>\n" +
                         " </div>\n" +
                     "</li> \n";
                }
                return Json(data);
            }
        }

        [HttpPost]
        public JsonResult FindFeedBack(int fbid)
        {
            using (var db = new onlineShopSWPContext())
            {
                Feedback fb = db.Feedbacks.Find(fbid);
                string data = "<input type=\"text\" name=\"fbcontent\" style=\"margin-top: 5px; height: 35px; width: 100%; border: none; border-bottom: 1px solid #EF5F21; outline: none; box-shadow: 0 0 5pt 2pt #d6d6d6; border-radius: 4px; padding: 0px 10px;\" value="+ fb.FbContent+ " />\n"+
                    "   <label>Rate</label>\n"+
                    "       <input type=\"radio\" value=\"1\" name=\"rate\" "+(fb.Rated == 1?"checked":"")+"> 1\n"+
                    "       <input type=\"radio\" value=\"2\" name=\"rate\" " + (fb.Rated == 2 ? "checked" : "") + "> 2\n" +
                    "       <input type=\"radio\" value=\"3\" name=\"rate\" " + (fb.Rated == 3 ? "checked" : "") + "> 3\n" +
                    "       <input type=\"radio\" value=\"4\" name=\"rate\" " + (fb.Rated == 4 ? "checked" : "") + "> 4\n" +
                    "       <input type=\"radio\" value=\"5\" name=\"rate\" " + (fb.Rated == 5 ? "checked" : "") + "> 5\n" +
                    "   <div style=\"text-align: center;\"\n>"+
                    "       <a class=\"add-re\" id=\"btadd\" style=\"cursor: pointer;\">SAVE</a>\n"+
                    "   </div>\n"+
                    " <input type=\"hidden\" name=\"containFbID\" value="+fb.FeedbackId+">\n";
                
                return Json(data);
            }
        }

        [HttpPost]
        public JsonResult UPdateFeedBack(string fbContent, int rate, int pId, int id, int fbId)
        {
            using (var db = new onlineShopSWPContext())
            {

                Feedback addfb = new Feedback { ProductId = pId, UserId = 1, Rated = rate, FbContent = fbContent, FeedbackDate = DateTime.Now.Date, Active = true, FeedbackId = fbId };
                db.Feedbacks.Update(addfb);
                db.SaveChanges();

                ViewBag.fblist = db.Feedbacks.Include(f => f.Product).Include(f => f.User).Where(f => f.ProductId == pId).ToList().Take(id * 3).OrderByDescending(fb => fb.FeedbackId);
                string data = "";
                foreach (Feedback fb in ViewBag.fblist)
                {
                    data += "<li data-content=\"television\" class=\"selected\">\n" +
                         "  <div class=\"comments-top-top\">\n" +
                            "   <div class=\"top-comment-left\">\n" +
                                "<img class=\"img-responsive\" src=" + fb.User.Avatar + " alt=\"\">\n" +
                            "   </div>\n" +
                            "   <div class=\"top-comment-right\">\n" +
                                "   <h6>" + fb.User.Fullname + " - " + (fb.FeedbackDate?.ToString("dd/MM/yyyy")) + "</h6>\n" +
                                "   <ul class=\"star-footer\">\n";
                    for (int i = 1; i <= fb.Rated; i++)
                    {
                        data += "   <li><i> </i></li>\n";
                    }
                    for (int i = (int)fb.Rated + 1; i <= 5; i++)
                    {
                        //data += "<li><i> </i></li>";
                    }
                    data += "   </ul>\n" +
                                "   \n<p>" + fb.FbContent + "</p>\n";
                    if (1 == fb.UserId)
                    {
                        data += " <div style=\"text-align: end\">\n" +
                                          "<a class=\"text-primary\">Edit</a> / <a class=\"text-danger\">Delete</a>\n" +
                                    "</div>\n";
                    }
                    data += " </div>\n" +
                         " </div>\n" +
                     "</li> \n";
                }
                return Json(data);
            }
        }
    }
}
