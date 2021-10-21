using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuiviWookies.Web.Ui.Areas.Identity.Data;
using SuiviWookies.Web.Ui.Data;

[assembly: HostingStartup(typeof(SuiviWookies.Web.Ui.Areas.Identity.IdentityHostingStartup))]
namespace SuiviWookies.Web.Ui.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SuiviWookiesWebUiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SuiviWookiesWebUiContextConnection")));

                services.AddDefaultIdentity<SuiviWookiesWebUiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SuiviWookiesWebUiContext>();
            });
        }
    }
}