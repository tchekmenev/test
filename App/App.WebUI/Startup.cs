using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App.WebUI.Startup))]
namespace App.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
