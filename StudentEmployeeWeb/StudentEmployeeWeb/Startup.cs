using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentEmployeeWeb.Startup))]
namespace StudentEmployeeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
