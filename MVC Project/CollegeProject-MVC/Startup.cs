using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeProject_MVC.Startup))]
namespace CollegeProject_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
