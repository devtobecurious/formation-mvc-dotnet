using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Models.Configuration;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Controllers
{
    public class TributesController : Controller
    {
        #region Fields
        private readonly GridConfiguration _gridConfiguration = null;
        private readonly ITributeService<Tribute> _tributeService = null;
        #endregion

        #region Constructors
        public TributesController(IOptions<GridConfiguration> gridOptions,
                                  ITributeService<Tribute> service)
        {
            this._gridConfiguration = gridOptions.Value;
            this._tributeService = service;
        }
        #endregion

        #region Public methods
        public IActionResult Index()
        {
            TributesViewModel model = new TributesViewModel();

            model.Tributes = this._tributeService.GetAll(this._gridConfiguration);

            return this.View(model);
        }
        #endregion
    }
}
