using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class WookiesController : Controller
    {
        public WookiesController()
        {

        }

        public IActionResult Index()
        {
            

            return View();
        }
    }
}
