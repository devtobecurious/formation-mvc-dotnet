using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.Models
{
    public class WeaponViewModel
    {
        #region Fields
        // private Weapon _weapon;
        #endregion

        #region Constructors
        public WeaponViewModel() : this(null)
        {

        }

        public WeaponViewModel(Weapon weapon)
        {
            if (weapon == null)
            {
                weapon = new Weapon();
            }

            this.Weapon = weapon;
        }
        #endregion

        #region Properties
        [Required(AllowEmptyStrings = false, ErrorMessage = "Libellé obligatoire")]
        [Remote("VerifyUnicLabel", "Weapons", ErrorMessage = "Le libellé doit être unique", HttpMethod = "POST")]
        public string Label { get; set; }

        [Range(0, 500, ErrorMessage = "Pas de puissance supérieure à 500")]
        public int Power { get; set; }

        public Weapon Weapon { get; private set; }
        #endregion
    }
}
