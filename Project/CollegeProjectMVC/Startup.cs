using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeProjectMVC.Startup))]
namespace CollegeProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
