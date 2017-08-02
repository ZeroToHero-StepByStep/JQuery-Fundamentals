using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQuerySelectors.Startup))]
namespace JQuerySelectors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
