using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ContactUs.Middelware;
using Microsoft.AspNetCore.Mvc;

namespace ContactUs
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            //app.MapWhen(context => context.Request.Query.ContainsKey("test"), MapWhenMethod);
            //app.Map("/home", test);
            app.UseMiddleware<Test>();
            //app.Map("/home", Test);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "test1",
                    pattern:"/codyad/{name}",
                    defaults:new{controller="Home",action="Messages"} 
                );
            });
        }
        public static void MapWhenMethod(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MapWhen");

            });
        }
        public static void test(IApplicationBuilder app)
        {app.Map("/index", config2 =>
        {
            config2.Use(async (context, next) =>
            {
                context.Response.Headers.Add("term","barghamadi");
                await next();
            });
            config2.Run(async (context) =>
            {
                var head = context.Response.Headers["term"].ToString();
                if (head=="barghamadi")
                {
                    context.Response.WriteAsync(head);
                }
                else
                {
                    context.Response.Redirect("/");
                }
            });
        });
    app.Use(async (context, next) =>
    {
        context.Response.Headers.Add("term", "mory");
        await next();
    });
    app.Run(async (context) =>
    {
        var head = context.Response.Headers["term"].ToString();
        if (head == "mory")
        {
            context.Response.WriteAsync(head);
        }
        else
        {
            context.Response.Redirect("/");
        }
    });
        }
    }
}
