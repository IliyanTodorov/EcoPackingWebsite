using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(EcoPacking.Web.Areas.Identity.IdentityHostingStartup))]

namespace EcoPacking.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}