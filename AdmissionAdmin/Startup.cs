using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdmissionAdmin.Startup))]
namespace AdmissionAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
