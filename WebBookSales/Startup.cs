using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBookSales.Startup))]
namespace WebBookSales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
