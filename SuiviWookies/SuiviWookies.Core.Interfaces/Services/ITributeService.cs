using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Interfaces.Services
{
    public interface ITributeService<T> : IBaseService<T> where T : class
    {
    }
}
