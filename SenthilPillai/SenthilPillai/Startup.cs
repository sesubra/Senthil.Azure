using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SenthilPillai.Startup))]
namespace SenthilPillai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
