using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Volkswagensisjon.Startup))]
namespace Volkswagensisjon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
