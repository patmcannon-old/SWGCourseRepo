using GuildBlog.Data.Interfaces;
using GuildBlog.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildBlog.Data.Repos
{
    public class GuildBlogDBRepo : IBlogPost
    {
        public ApplicationDbContext repo { get; set; }

        public List<Posting> GetPostings()
        {
            return repo.Postings.ToList();
        }
        public void AddPosting(Posting posting)
        {
            repo.Postings.Add(posting);
        }
        public void EditPosting(Posting posting)
        {
            repo.Entry(posting).State = System.Data.Entity.EntityState.Modified;
            repo.SaveChanges();
        }
        public void DeletePosting(int postingID)
        {
            var model = repo.Postings.Where(x => x.PostingID == postingID).FirstOrDefault();
            if (model != null)
            {
                repo.Postings.Remove(model);
                repo.SaveChanges();
            }
        }
    }
}
