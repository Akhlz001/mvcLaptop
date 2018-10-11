using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laptops_LOL.Startup))]
namespace Laptops_LOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
