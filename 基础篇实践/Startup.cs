using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(基础篇实践.Startup))]
namespace 基础篇实践
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
