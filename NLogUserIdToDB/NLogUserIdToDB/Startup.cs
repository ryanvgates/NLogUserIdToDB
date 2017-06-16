using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NLogUserIdToDB.Startup))]
namespace NLogUserIdToDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
