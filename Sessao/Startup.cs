using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sessao.Startup))]
namespace Sessao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
