using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewFinal.Startup))]
namespace NewFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
