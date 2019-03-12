using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StuttgartCore.Middleware;
using StuttgartCore.Models;
using StuttgartCore.Pages.modul02;
using StuttgartCore.Pages.modul05;

namespace StuttgartCore
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
            services.AddSession(options => options.Cookie.HttpOnly = true);
            services.AddResponseCaching();
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddCookieTempDataProvider();
           services.AddSingleton<HannesKlasse>();
            services.AddDbContext<northwindContext>(o=>
            o.UseSqlServer(Configuration.GetConnectionString("Northwind1")));
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            AppDomain.CurrentDomain.SetData("MapPath", env.ContentRootPath);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           // app.UseMyMiddleware();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseResponseCaching();
           
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("BEFORE RESPONSE");
            //    await next();
            //    await context.Response.WriteAsync("AFTER RESPONSE");
            //});
            ////app.Use(_next=>async ctx =>
            //{

            //    await ctx.Response.WriteAsync("before 1");
            //    await _next(ctx);
            //    await ctx.Response.WriteAsync("after 1");

            //});
            //app.Use(next =>
            //{
            //    return async ctx =>
            //    {
            //        await ctx.Response.WriteAsync("before 2");
            //        next(ctx);
            //        await ctx.Response.WriteAsync("after 2");
            //    };
            //});

            //app.Use(next =>
            //{
            //    return async ctx =>
            //    {
            //        await ctx.Response.WriteAsync("before 3");
            //        next(ctx);
            //        await ctx.Response.WriteAsync("after 3");
            //    };
            //});
            app.UseMvc();
            
            app.MapWhen(context => context.Request.Path.ToString().Contains("imageloader.ashx"),
                appBranch =>
                {
                   // appBranch.UseMiddleware<ImageLoader>(); //ohne Extension Methode
                    appBranch.UseImageLoader();
                });
         
        }
    }
}
