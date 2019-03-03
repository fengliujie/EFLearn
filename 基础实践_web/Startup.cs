using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(基础实践_web.Startup))]
namespace 基础实践_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
