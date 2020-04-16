using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildBlog.MVC.Models
{
    public class Posting
    {
        public int PostingID { get; set; }
        public DateTime? PostingDate { get; set; }
        public string PostingTitle { get; set; }
        public string PostingAuthor { get; set; }
        [AllowHtml]
        public string PostingBody { get; set; }
        public string Hashtag { get; set; }
        public bool IsApproved { get; set; }
    }
}