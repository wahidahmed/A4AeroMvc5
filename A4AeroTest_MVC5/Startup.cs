using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4AeroTest_MVC5.Startup))]
namespace A4AeroTest_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
