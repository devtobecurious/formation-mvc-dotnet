using SuiviWookies.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class BirthService : IBirthService
    {
        #region Fields
        private static Random __rand = new Random();
        #endregion

        #region Public methods
        public int Compute(int cityId)
        {
            return __rand.Next(1, 5000);
        }
        #endregion
    }
}
