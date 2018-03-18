using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoFactorAuthDemo.Startup))]
namespace TwoFactorAuthDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
