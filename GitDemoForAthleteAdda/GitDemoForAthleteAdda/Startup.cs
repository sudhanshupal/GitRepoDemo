using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemoForAthleteAdda.Startup))]
namespace GitDemoForAthleteAdda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
