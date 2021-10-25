using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

[assembly: HostingStartup(typeof(SuiviWookies.Web.Ui.Startups.StartupB))]
namespace SuiviWookies.Web.Ui.Startups
{
    public class StartupB : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Debug.Write(nameof(StartupB));
        }
    }
}
