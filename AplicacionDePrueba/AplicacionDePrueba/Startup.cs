using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacionDePrueba.Startup))]
namespace AplicacionDePrueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
