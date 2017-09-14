using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab.themeapps.Startup))]
namespace lab.themeapps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
