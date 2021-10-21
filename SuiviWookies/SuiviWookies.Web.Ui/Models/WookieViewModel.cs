using Microsoft.AspNetCore.Mvc;
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
        public WookieViewModel() : this(null)
        {
        }

        public WookieViewModel(Wookie wookie = null)
        {
            if (wookie == null)
            {
                wookie = new Wookie();
            }

            this._wookie = wookie;
        }
        #endregion

        #region Properties
        
        //[StringLength(20, ErrorMessage = "Hey tu sais pas écrire ?!")]
        [Remote("IsValidSurname", "Wookies", HttpMethod = "POST", AdditionalFields = nameof(Surname))]
        public string Surname { get;set; }

        public Wookie Wookie { get => this._wookie; }
        #endregion
    }
}
