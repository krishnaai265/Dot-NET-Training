using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(apiClient.Startup))]
namespace apiClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
