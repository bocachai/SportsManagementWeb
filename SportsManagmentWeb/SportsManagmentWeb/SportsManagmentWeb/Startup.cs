using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsManagmentWeb.Startup))]
namespace SportsManagmentWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
