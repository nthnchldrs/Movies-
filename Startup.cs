using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movies_.Startup))]
namespace Movies_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
