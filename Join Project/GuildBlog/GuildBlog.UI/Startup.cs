using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuildBlog.UI.Startup))]
namespace GuildBlog.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
