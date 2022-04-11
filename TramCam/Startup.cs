using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TramCam.Startup))]
namespace TramCam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
