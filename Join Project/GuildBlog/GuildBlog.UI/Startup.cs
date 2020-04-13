using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuildBlog.MVC.Startup))]
namespace GuildBlog.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
