using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(userTemplate.Startup))]
namespace userTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
