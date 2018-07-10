using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bio.Startup))]
namespace Bio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
