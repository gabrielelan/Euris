using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EURISTest.Startup))]
namespace EURISTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
