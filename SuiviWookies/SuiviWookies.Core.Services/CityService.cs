using SuiviWookies.Core.Interfaces;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class CityService : ICityService<City>
    {
        #region Fields
        private readonly IBirthService _birthService = null;
        #endregion

        #region Constructors
        public CityService(IBirthService service)
        {
            this._birthService = service;
        }
        #endregion

        #region Public methods
        public IList<City> GetAll()
        {
            IList<City> cities = new List<City>()
            {
                new City() 
                { 
                    Id = 1
                },
                new City()
                {
                    Id = 2
                }
            };

            foreach (var city in cities)
            {
                city.BirthCount = _birthService.Compute(city.Id);
            }

            return cities;
        }

        public IList<City> GetAll(GridConfiguration gridConfiguration)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
