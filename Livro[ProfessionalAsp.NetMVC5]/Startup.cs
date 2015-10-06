using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Livro_ProfessionalAsp.NetMVC5_.Startup))]
namespace Livro_ProfessionalAsp.NetMVC5_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
