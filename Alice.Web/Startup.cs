﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Alice.Data.Context;
using Alice.Service.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace Alice.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<LuxuryContext>(ServiceLifetime.Transient);
            services.AddTransient<SiteSettingsService>();
            services.AddTransient<GalleryPoolService>();
            services.AddTransient<CategoryService>();
            services.AddTransient<CategoriesSlidersService>();
            services.AddTransient<StaticPagesService>();
            services.AddTransient<TourCategoriesService>();
            services.AddTransient<TourGalleriesService>();
            services.AddTransient<TourService>();
            services.AddTransient<TourPlanService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "Content")),
                RequestPath = new PathString("/Content")
            });
            app.UseCookiePolicy();



            app.UseMvc(routes =>
            {
                routes.MapRoute("category", "{categoryName}",
            defaults: new { controller = "Category", action = "Detail" });

                routes.MapRoute("subCategory", "{parentCategoryName}/{categoryName}",
            defaults: new { controller = "Category", action = "Detail" });


                routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}",
            defaults: new { controller = "Category", action = "Detail" });

                routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/{tourPage?}", defaults: new { controller = "Tour", action = "Detail"  });
                //routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/Tour-Plan", defaults: new { controller = "Tour", action = "SubDetail" });
                //routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/Tour-Map", defaults: new { controller = "Tour", action = "SubDetail" });
                //routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/Hotel", defaults: new { controller = "Tour", action = "SubDetail" });
                //routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/Conditions", defaults: new { controller = "Tour", action = "SubDetail" });
                //routes.MapRoute("perSubCategory", "{parentCategoryName}/{subParentCategoryName}/{categoryName}/{tourUrl}/Gallery", defaults: new { controller = "Tour", action = "SubDetail" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
