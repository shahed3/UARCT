using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UARCT.EDU.Startup))]
namespace UARCT.EDU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
