using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaMVC.Startup))]
namespace pruebaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
