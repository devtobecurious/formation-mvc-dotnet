using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Models.Configuration;
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
    public class TributeUnitTest : IDisposable
    {
        #region Public methods
        [Fact]
        public void ShouldRun()
        {
            var controller = this.GetNewOne(0);
            Assert.NotNull(controller);
        }

        [Fact]
        public void ShouldDisplaySetListOf2Tributes()
        {
            int nbItems = 2;

            var result = this.GetNewOne(nbItems).Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<TributesViewModel>(viewResult.ViewData.Model);

            Assert.Equal(nbItems, model.Tributes.Count);
        }
        #endregion

        #region Internal methods
        private TributesController GetNewOne(int size = 0)
        {
            // using var context = new MainDbContext(contextBuilder.Options);

            Moq.Mock<IOptions<GridConfiguration>> mock = new Moq.Mock<IOptions<GridConfiguration>>();
            mock.Setup(item => item.Value).Returns(new GridConfiguration() { Size = size });

            var context = this.GetNewOneContext();
            this.SeedData(size, context);

            TributeService service = new TributeService(context);

            var controller = new TributesController(mock.Object, service);

            return controller;
        }

        private void SeedData(int size, MainDbContext context)
        {
            for (int i = 0; i < size + 1; i++)
            {
                context.Tributes.Add(new Core.Models.Tribute());
            }

            context.SaveChanges();
        }

        private MainDbContext GetNewOneContext()
        {
            var contextBuilder = new DbContextOptionsBuilder();

            contextBuilder.UseInMemoryDatabase("wookies");

            return new MainDbContext(contextBuilder.Options);
        }

        public void Dispose()
        {
            
        }
        #endregion
    }
}
