using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bicicletas.Startup))]
namespace Bicicletas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
