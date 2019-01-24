using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenBlog.UI.Startup))]
namespace OpenBlog.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
