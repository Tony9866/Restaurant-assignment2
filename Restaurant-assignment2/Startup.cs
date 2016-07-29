using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurant_assignment2.Startup))]
namespace Restaurant_assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
