using SuiviWookies.Core.DataContext;
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
    public class TributeService : ITributeService<Tribute>
    {
        #region Fields
        private readonly MainDbContext _context;
        #endregion

        #region Constructors
        public TributeService(MainDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Tribute> GetAll()
        {
            IList<Tribute> list = new List<Tribute>()
            {
                new Tribute(),
                new Tribute()
            };

            return list;
        }

        public IList<Tribute> GetAll(GridConfiguration gridConfiguration)
        {
            var query = from item in this._context.Tributes
                        select item;

            return query.Take(gridConfiguration.Size).ToList();
        }
        #endregion
    }
}
