using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Procesos.WebApp.Startup))]
namespace Procesos.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
