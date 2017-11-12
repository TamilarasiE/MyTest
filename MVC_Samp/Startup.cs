using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Samp.Startup))]
namespace MVC_Samp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
