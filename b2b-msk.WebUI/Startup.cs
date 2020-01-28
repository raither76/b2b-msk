using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(b2b_msk.WebUI.Startup))]
namespace b2b_msk.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
