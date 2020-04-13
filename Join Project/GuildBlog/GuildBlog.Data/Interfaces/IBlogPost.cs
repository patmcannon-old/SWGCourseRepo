using GuildBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildBlog.Data.Interfaces
{
    interface IBlogPost
    {
        List<Posting> GetPostings();
        void AddPosting(Posting posting);
        void EditPosting(Posting posting);
        void DeletePosting(int postingID);
    }
}
