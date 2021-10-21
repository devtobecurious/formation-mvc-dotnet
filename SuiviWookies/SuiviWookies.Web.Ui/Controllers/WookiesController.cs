using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Services;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class WookiesController : Controller
    {
        #region Fields
        private readonly WookieService _service;
        private readonly IWeaponService<Weapon> _weaponService;
        #endregion

        #region Constructors
        public WookiesController(WookieService service,
                                 IWeaponService<Weapon> weaponService)
        {
            this._service = service;
            this._weaponService = weaponService;
        }
        #endregion

        #region Public methods

        public IActionResult Index()
        {
            

            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon() { Id = 1, Label = "Blaster"},
                new Weapon() { Id = 2, Label = "Light saber"}
            };

            List<Wookie> list = new List<Wookie>()
            {
                new Wookie(),
                new Wookie()
            };

            this.ViewBag.List = list;
            this.ViewData["MA_LIST"] = list;

            this.ViewBag.Weapons = weapons;


            return View(list);
        }

        public async Task<IActionResult> Index2()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon() { Id = 1, Label = "Blaster"},
                new Weapon() { Id = 2, Label = "Light saber"}
            };

            //List<Wookie> list = new List<Wookie>()
            //{
            //    new Wookie(),
            //    new Wookie()
            //};

            //this.ViewBag.List = list;
            //this.ViewData["MA_LIST"] = list;

            ///this.ViewBag.Weapons = weapons;

            var listWookies = await this._service.GetAll();


            WookiesViewModel viewModel = new WookiesViewModel()
            {
                Wookies = listWookies,
                Weapons = weapons
            };

            return View("Index", viewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View(this.CreateDefaultViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(WookieViewModel viewModel)
        {
            if (this.ModelState.IsValid)
            {
                // this.ModelState.AddModelError()

                await this._service.Save(viewModel.Wookie);
            }

            return this.View(this.CreateDefaultViewModel());
        }

        [HttpPost]
        public IActionResult IsValidSurname(WookieViewModel model)
        {
            return this.Json(false);
        }

        [HttpPost]
        public IActionResult IsValidSurname2(string surname)
        {
            return this.Json(false);
        }
        #endregion

        #region Internal methods
        private WookieViewModel CreateDefaultViewModel()
        {
            var viewModel = new WookieViewModel()
            {
                Weapons = this.GetWeaponList()
            };

            return viewModel;
        }

        private IList<Weapon> GetWeaponList()
        {
            return this._weaponService.GetAll();
        }
        #endregion
    }
}
