using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Models
{
    public class TributesViewModel
    {
        #region Properties
        public IList<Tribute> Tributes { get; set; }
        #endregion
    }
}
