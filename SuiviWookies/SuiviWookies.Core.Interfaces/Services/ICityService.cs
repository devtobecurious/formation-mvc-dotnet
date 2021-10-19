using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using System;

namespace SuiviWookies.Core.Interfaces
{
    public interface ICityService<T> : IBaseService<T> where T:class
    {
    }
}
