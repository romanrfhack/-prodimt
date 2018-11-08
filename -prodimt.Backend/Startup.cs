using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_prodimt.Backend.Startup))]
namespace _prodimt.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
