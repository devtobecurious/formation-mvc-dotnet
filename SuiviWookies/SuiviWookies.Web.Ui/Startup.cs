using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SuiviWookies.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuiviWookies.Web.Ui.ExtensionMethods;
using SuiviWookies.Core.Models.Configuration;

namespace SuiviWookies.Web.Ui
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
            string xpMin = this.Configuration["Game:XPmin"];

            services.AddInjectionDependencies(this.Configuration)
                    .AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var conf = this.Configuration.GetSection("Game").Get<GameConfiguration>();

            if (env.IsDevelopment() && env.IsEnvironment("MonEnvironment"))
            {
                app.UseDeveloperExceptionPage();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapPost("jedi:regex(^\\d{2}-jedi-.*)", httpContext =>
                //{
                //    // return httpContext.Response.w
                //});

                //endpoints.MapControllerRoute(
                //    name: "onewookie",
                //    pattern: "wookie/{id?}",
                //    constraints: new { id = @"\d" },
                //    defaults: new { controller = "Wookies", action = "Edit" }
                //);

                //endpoints.MapControllerRoute(
                //    name: "thewookies",
                //    // pattern: "les-wookies/{search:regex(*)}/{index:maxlength(2)}/{page:int}",
                //    pattern: "les-wookies",
                //    defaults: new { controller = "Wookies", action = "Index2" }
                //);

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
