using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(broadcast_live.Startup))]
namespace broadcast_live
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
