using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Copyhawk.TestApplication.Startup))]
namespace Copyhawk.TestApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
