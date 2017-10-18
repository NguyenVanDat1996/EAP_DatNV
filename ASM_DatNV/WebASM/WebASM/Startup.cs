using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebASM.Startup))]
namespace WebASM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
