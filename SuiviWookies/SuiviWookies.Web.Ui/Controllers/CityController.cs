using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Services;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class CityController : Controller
    {
        #region Fields
        private readonly CityService _service;
        #endregion

        #region Constructors
        public CityController(CityService service)
        {
            this._service = service;
        }
        #endregion

        #region Public methods

        public IActionResult Index()
        {
            CityViewModel model = new CityViewModel();

            model.Cities = this._service.GetAll();

            return View(model);
        }
        #endregion
    }
}
