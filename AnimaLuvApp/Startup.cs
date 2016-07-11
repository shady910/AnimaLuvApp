using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimaLuvApp.Startup))]
namespace AnimaLuvApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
