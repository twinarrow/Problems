using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspportal.Startup))]
namespace aspportal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
