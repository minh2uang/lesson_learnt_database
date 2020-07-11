using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Lessons_Learned_Database.Areas.Identity.IdentityHostingStartup))]
namespace Lessons_Learned_Database.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}