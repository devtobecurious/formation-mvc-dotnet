using SuiviWookies.Core.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Interfaces.Services
{
    public interface IBaseService<T> where T: class
    {
        IList<T> GetAll();

        IList<T> GetAll(GridConfiguration gridConfiguration);
    }
}
