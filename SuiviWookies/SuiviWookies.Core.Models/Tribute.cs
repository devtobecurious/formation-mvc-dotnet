using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Models
{
    public class Tribute : BaseModel
    {
        #region Properties
        public int Id { get; set; }

        public string Label { get; set; }

        public string PictureUrl { get; set; }

        public string Shout { get; set; }

        public int NbWookies { get; set; }
        #endregion
    }
}
