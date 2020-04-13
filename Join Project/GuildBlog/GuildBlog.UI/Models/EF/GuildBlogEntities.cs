using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuildBlog.UI.Models.EF
{
    public class GuildBlogEntities : DbContext
    {
        public GuildBlogEntities()
            : base("GuildBlog")
        {
        }
        public DbSet<Posting> Postings { get; set; }
    }
}