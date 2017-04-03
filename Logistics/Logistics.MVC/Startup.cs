using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Logistics.MVC.Startup))]
namespace Logistics.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
