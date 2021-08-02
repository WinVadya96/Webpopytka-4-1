using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webpopytka_4_1.Startup))]
namespace Webpopytka_4_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
