using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryDom.Startup))]
namespace jQueryDom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
