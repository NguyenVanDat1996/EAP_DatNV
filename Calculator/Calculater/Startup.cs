using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calculater.Startup))]
namespace Calculater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
