using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soft.Startup))]
namespace Soft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
