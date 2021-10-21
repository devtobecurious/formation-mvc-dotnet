using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class WeaponService : IWeaponService<Weapon>
    {
        #region Fields
        private readonly MainDbContext _context;
        #endregion

        #region Constructors
        public WeaponService([NotNullAttribute] MainDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Weapon> GetAll()
        {
            return this._context.Weapons.ToList();
        }

        public IList<Weapon> GetAll(GridConfiguration gridConfiguration)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public bool VerifyUnic(string label)
        {
            return ! this._context.Weapons.Any(item => item.Label.ToLower() == label.ToLower());
        }
        #endregion
    }
}
