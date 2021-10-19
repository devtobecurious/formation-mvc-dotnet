namespace SuiviWookies.Core.Models
{
    public class City : BaseModel
    {
        #region Properties
        public int Id { get; set; }

        public string Label { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int BirthCount { get; set; }

        #endregion Properties
    }
}