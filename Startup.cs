using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricProject_Team9.Startup))]
namespace CentricProject_Team9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
