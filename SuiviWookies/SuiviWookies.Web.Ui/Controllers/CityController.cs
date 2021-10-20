using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Interfaces;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Services;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class CityController : Controller
    {
        #region Fields
        private readonly ICityService<City> _service;
        #endregion

        #region Constructors
        public CityController(ICityService<City> service)
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

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        // public IActionResult Add(string gps, string label)
        //public IActionResult Add(City city)
        public IActionResult Add(TestOne test)
        {
            string newGps = this.Request.Form["gps"];

            return this.View();
        }

        public IActionResult Update(City city)
        {
            return this.View();
        }
        #endregion
    }

    public class TestOne
    {
        public string Label { get; set; }
        public int Gps { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Child OneChild { get; set; }
    }

    public class Child
    {   
        public string Label { get; set; }

    }
}
