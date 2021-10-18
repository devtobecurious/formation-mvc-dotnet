using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Models
{
    public class WookiesViewModel
    {
        #region Properties
        public IList<Wookie> Wookies { get; set; }

        public IList<Weapon> Weapons { get; set; }

        public int WeaponId { get; set; }
        #endregion
    }
}
