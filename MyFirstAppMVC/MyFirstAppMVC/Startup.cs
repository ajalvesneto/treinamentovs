using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstAppMVC.Startup))]
namespace MyFirstAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
