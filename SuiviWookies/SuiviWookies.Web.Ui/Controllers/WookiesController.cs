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
    public class WookiesController : Controller
    {
        private readonly WookieService _service;

        public WookiesController(WookieService service)
        {
            this._service = service;
        }

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
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(WookieViewModel viewModel)
        {
            await this._service.Save(viewModel.Wookie);

            return this.View();
        }
    }
}
