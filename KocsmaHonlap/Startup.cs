using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KocsmaHonlap.Startup))]
namespace KocsmaHonlap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
