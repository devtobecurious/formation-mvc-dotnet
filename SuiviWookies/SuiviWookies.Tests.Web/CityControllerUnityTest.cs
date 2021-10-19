using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Services;
using SuiviWookies.Web.Ui.Controllers;
using SuiviWookies.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuiviWookies.Tests.Web
{
    public class CityControllerUnityTest
    {
        #region Public methods
        [Fact]
        public void ShouldBeRun()
        {
            CityController controller = new CityController(this.GetNewOne());
            Assert.NotNull(controller);
        }
        
        [Fact]
        public void ShouldGetTwoCities()
        {
            // Arrange
            CityController controller = new CityController(this.GetNewOne());

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<CityViewModel>(viewResult.ViewData.Model);

            Assert.Equal(2, model.Cities.Count);
        }
        #endregion

        #region Internal methods
        private CityService GetNewOne()
        {
            return new Core.Services.CityService(new BirthService());
        }
        #endregion
    }
}
