using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEFAZ.CursoMVC.UI.Startup))]
namespace SEFAZ.CursoMVC.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
