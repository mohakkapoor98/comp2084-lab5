using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWithSocialAuth.Startup))]
namespace AppWithSocialAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
