using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumatorWebApp.Startup))]
namespace SumatorWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
