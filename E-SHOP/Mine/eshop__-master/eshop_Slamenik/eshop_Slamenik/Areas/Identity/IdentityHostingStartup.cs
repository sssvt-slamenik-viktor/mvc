using System;
using eshop_Slamenik.Data;
using eshop_Slamenik.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(eshop_Slamenik.Areas.Identity.IdentityHostingStartup))]
namespace eshop_Slamenik.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<eshop_SlamenikContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MssqlSchoolConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<eshop_SlamenikContext>();
            });

        }
    }
}