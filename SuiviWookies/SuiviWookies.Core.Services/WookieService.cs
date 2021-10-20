using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class WookieService
    {
        #region Constants
        public static int __NB_INSTANCES = 0;
        #endregion

        #region Fields
        private readonly MainDbContext _context;
        #endregion

        #region Constructors
        public WookieService(MainDbContext context)
        {
            __NB_INSTANCES++;
            this._context = context;
        }
        #endregion

        public async Task<IList<Models.Wookie>> GetAll()
        {
            List<Models.Wookie> wookies2 = new();

            IList<Models.Wookie> wookies = new List<Models.Wookie>()
            {
                new Models.Wookie() { Id = 1, Birthday = DateTime.Now, Size = 150, Surname = "Chewie" } ,
                new Models.Wookie() { Id = 2, Birthday = DateTime.Now.AddMonths(-10), Size = 120, Surname = "Chewa" },
            };

            return await Task.FromResult(wookies);
        }

        public async Task Save(Wookie wookie)
        {
            this._context.Wookies.Add(wookie);
            await this._context.SaveChangesAsync();
        }
    }
}
