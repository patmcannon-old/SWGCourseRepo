using GuildBlog.MVC.Models;
using GuildBlog.MVC.Models.ViewModels;
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
            List<PostingVM> postings = new List<PostingVM>();
            List<Posting> list = repo.GetPostings();
            foreach (var post in list)
            {
                PostingVM vm = new PostingVM();
                vm.Posting = post;
                vm.Hashtags = post.Hashtag.Split(' ').ToList();
                postings.Add(vm);
            }
            return View(postings);
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