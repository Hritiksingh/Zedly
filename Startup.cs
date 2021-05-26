using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zedly.Startup))]
namespace Zedly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
