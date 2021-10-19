using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Models.Configuration;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, 
                              IConfiguration configuration, 
                              IOptions<GameConfiguration> gameOptions)
        {
            int minXP = int.Parse(configuration["Game:XPmin"]);

            var conf = configuration.GetSection("Game").Get<GameConfiguration>(option =>
            {
                
            });

            var conf2 = gameOptions.Value;

            _logger = logger;
            // INTERDIT !!! var list = query.ToList().Where(item => item;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
