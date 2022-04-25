using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.EntityFrameworkCore;

using PetEShopWebMVC.Data;
using PetEShopWebMVC.Interfaces.Services.Shop;
using PetEShopWebMVC.Services.Shop;
using PetEShopWebMVC.Services.Test;
using PetEShopWebMVC.Interfaces.Services.Test;
using PetEShopWebMVC.Interfaces.Repos.Test;
using PetEShopWebMVC.Repos.Test;

namespace PetEShopWebMVC
{



    public class Startup
    {



        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                //options.UseSqlServer(
                //    Configuration.GetConnectionString("DeprecatedConnection")));
                //options.UseMySQL(
                //    Configuration.GetConnectionString("DefaultConnection")));
                options.UseSqlServer(
                    //Configuration.GetConnectionString("MssqlConnection")));
                    //Configuration.GetConnectionString("MssqlSchoolConnection")));
                    //Configuration.GetConnectionString("MssqlTestSchoolConnection")));
                    Configuration.GetConnectionString("MssqlSchoolConnection")));
                    //Configuration.GetConnectionString("MssqlG4Agr2Connection")));
            services.AddDatabaseDeveloperPageExceptionFilter();



                        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            // Add more dependencies for the DI resolver.
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IHouseService, HouseService>();

            //services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IUserRepo, TestUserRepo>();
            services.AddScoped<IPersonRepo, PersonRepo>();
            services.AddScoped<IAuthRepo, AuthRepo>();
            services.AddScoped<IHouseRepo, HouseRepo>();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }



    }



}
