using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Class9.Startup))]
namespace Class9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
