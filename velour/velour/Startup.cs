using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(velour.Startup))]
namespace velour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
