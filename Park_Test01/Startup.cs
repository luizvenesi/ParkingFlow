using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Park_Test01.Startup))]
namespace Park_Test01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
