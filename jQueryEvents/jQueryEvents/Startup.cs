using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryEvents.Startup))]
namespace jQueryEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
