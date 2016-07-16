using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bLaserTag.Web.Startup))]
namespace bLaserTag.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
