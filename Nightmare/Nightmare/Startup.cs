using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nightmare.Startup))]
namespace Nightmare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
