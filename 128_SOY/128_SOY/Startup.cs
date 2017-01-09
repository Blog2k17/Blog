using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_128_SOY.Startup))]
namespace _128_SOY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
