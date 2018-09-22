using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimerasoluionTopicos.Startup))]
namespace PrimerasoluionTopicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
