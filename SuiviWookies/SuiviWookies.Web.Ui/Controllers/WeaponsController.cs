using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class WeaponsController : Controller
    {
        #region Fields
        private readonly IWeaponService<Weapon> _service;
        #endregion

        #region Constructors
        public WeaponsController(IWeaponService<Weapon> service)
        {

        }
        #endregion

        #region Public methods
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult VerifyUnicLabel(string label)
        {
            bool isValid = this._service.VerifyUnic(label);

            return this.Json(isValid);
        }

        [HttpPost]
        public IActionResult Add(Models.WeaponViewModel viewModel)
        {
            if (this.ModelState.IsValid)
            {
                // save 
            }

            return this.View();
        }
        #endregion
    }
}
