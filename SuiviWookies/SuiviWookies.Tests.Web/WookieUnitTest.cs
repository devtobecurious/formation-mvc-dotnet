using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace SuiviWookies.Tests.Web
{
    public class WookieUnitTest
    {
        [Fact]
        public void ShouldRun()
        {
            var builder = new DbContextOptionsBuilder();

            SuiviWookies.Web.Ui.Controllers.WookiesController controller = new(new Core.Services.WookieService(new Core.DataContext.MainDbContext(builder.Options)));
            Assert.NotNull(controller);
        }
    }
}
