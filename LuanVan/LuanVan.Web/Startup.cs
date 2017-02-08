using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuanVan.Web.Startup))]
namespace LuanVan.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
