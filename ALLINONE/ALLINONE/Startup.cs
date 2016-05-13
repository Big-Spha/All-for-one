using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALLINONE.Startup))]
namespace ALLINONE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
