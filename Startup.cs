using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finaldesign_template.Startup))]
namespace finaldesign_template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
