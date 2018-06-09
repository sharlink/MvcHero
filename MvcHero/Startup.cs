using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcHero.Startup))]
namespace MvcHero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
