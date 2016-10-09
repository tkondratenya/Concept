using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Concept.Web.Startup))]
namespace Concept.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
