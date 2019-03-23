using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dareurbody.Startup))]
namespace Dareurbody
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
