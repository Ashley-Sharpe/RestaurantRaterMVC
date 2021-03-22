using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantRaterMVC.Startup))]
namespace RestaurantRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
