﻿using SuiviWookies.Core.Interfaces;
using SuiviWookies.Core.Models;
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
        private readonly BirthService _birthService = null;
        #endregion

        #region Constructors
        public CityService(BirthService service)
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
        #endregion
    }
}
