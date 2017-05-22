using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSMS.Startup))]
namespace TSMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
