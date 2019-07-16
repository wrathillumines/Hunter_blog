using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hunter_blog.Startup))]
namespace Hunter_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
