using GuildBlog.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildBlog.MVC.Models.ViewModels
{
    public class PostingVM
    {
        public List<string> Hashtags { get; set; }
        public Posting Posting { get; set; }
    }
}