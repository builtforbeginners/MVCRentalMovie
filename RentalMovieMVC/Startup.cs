using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalMovieMVC.Startup))]
namespace RentalMovieMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
