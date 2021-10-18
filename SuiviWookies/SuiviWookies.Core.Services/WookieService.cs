using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class WookieService
    {
        public static int __NB_INSTANCES = 0;

        public WookieService()
        {
            __NB_INSTANCES++;
        }

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
    }
}
