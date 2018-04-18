using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageGetter.Startup))]
namespace ImageGetter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
