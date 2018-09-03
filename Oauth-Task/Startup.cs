using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oauth_Task.Startup))]
namespace Oauth_Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
