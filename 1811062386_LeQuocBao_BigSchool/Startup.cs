using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811062386_LeQuocBao_BigSchool.Startup))]
namespace _1811062386_LeQuocBao_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
