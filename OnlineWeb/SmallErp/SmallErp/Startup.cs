using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallErp.Startup))]
namespace SmallErp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
