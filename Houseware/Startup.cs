using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Houseware.Data;
using Houseware.Data.Interface;
using Houseware.Data.Models;
using Houseware.Data.Repository;
using Houseware.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Houseware
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
              .SetBasePath(hostingEnvironment.ContentRootPath)
              .AddJsonFile("appsettings.json")
              .Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            //Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Authentication, Identity config
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IItemsRepository, ItemRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));

            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider svc)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseIdentity();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "Itemdetails",
                   template: "Item/Details/{ItemId?}",
                   defaults: new { Controller = "Item", action = "Details" });

                routes.MapRoute(
                    name: "categoryfilter",
                    template: "Item/{action}/{category?}",
                    defaults: new { Controller = "Item", action = "List" });

                routes.MapRoute(
                    name: "shoppingCart",
                    template: "ShoppingCart/Checkout",
                    defaults: new {Controller="ShoppingCart", action="Index"}
                    );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{Id?}");
               
            });

            DbInitializer.Seed(svc);
        }
    }
}
