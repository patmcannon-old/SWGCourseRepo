using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildBlog.Data.Models
{
    public class Posting
    {
        public int PostingID { get; set; }
        public DateTime PostingDate { get; set; }
        public string PostingTitle { get; set; }
        public string PostingAuthor { get; set; }
        public string PostingBody { get; set; }
    }
}