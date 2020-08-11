using System;
using elFinder.NetCore.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(elFinder.NetCore.Web.Areas.Identity.IdentityHostingStartup))]
namespace elFinder.NetCore.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<FileMangerDbContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("FileMangerDbContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<FileMangerDbContext>();
            });
        }
    }
}