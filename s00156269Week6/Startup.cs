using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(s00156269Week6.Startup))]
namespace s00156269Week6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
