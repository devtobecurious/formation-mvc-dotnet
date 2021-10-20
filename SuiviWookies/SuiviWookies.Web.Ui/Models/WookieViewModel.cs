using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Models
{
    public class WookieViewModel
    {
        #region Fields
        private Wookie _wookie;
        #endregion

        #region Constructors
        public WookieViewModel(Wookie wookie = null)
        {
            if(wookie == null)
            {
                wookie = new Wookie();
            }

            this._wookie = wookie;
        }
        #endregion

        #region Properties
        [Required]
        public string Surname { get => this._wookie.Surname; set => this._wookie.Surname = value; }

        public Wookie Wookie { get => this._wookie; }
        #endregion
    }
}
