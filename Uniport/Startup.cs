using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uniport.Startup))]
namespace Uniport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
