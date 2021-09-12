using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizzWheelSummartive_2.Startup))]
namespace BizzWheelSummartive_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
