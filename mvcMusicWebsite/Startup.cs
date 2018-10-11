using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMusicWebsite.Startup))]
namespace mvcMusicWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
