using GuildBlog.MVC.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildBlog.MVC.Controllers
{
    public class HomeController : Controller
    {
        GuildBlogDBRepo repo = new GuildBlogDBRepo();

        public ActionResult Index()
        {
            return View(repo.GetPostings());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}