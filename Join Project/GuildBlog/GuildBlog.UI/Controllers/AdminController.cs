using GuildBlog.MVC.Models;
using GuildBlog.MVC.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildBlog.UI.Controllers
{
    public class AdminController : Controller
    {
        GuildBlogDBRepo repo = new GuildBlogDBRepo();
        // GET: Admin
        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(Posting posting)
        {
            posting.PostingDate = DateTime.Today;
            posting.PostingAuthor = "John Doe";
            repo.AddPosting(posting);
            return View("AddPost");
        }
    }
}