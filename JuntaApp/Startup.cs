using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JuntaApp.Startup))]
namespace JuntaApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
