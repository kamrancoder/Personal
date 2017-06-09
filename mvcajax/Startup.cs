using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcajax.Startup))]
namespace mvcajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
