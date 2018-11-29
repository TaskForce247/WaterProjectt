using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaterProjectt.Startup))]
namespace WaterProjectt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
