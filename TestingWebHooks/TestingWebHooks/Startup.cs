using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingWebHooks.Startup))]
namespace TestingWebHooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
