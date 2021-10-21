using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Interfaces.Services
{
    public interface IWeaponService<T> : IBaseService<T> where T:class
    {
        bool VerifyUnic(string label);
    }
}
