using Microsoft.EntityFrameworkCore;
using SuiviWookies.Core.Services;
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

            var context = new Core.DataContext.MainDbContext(builder.Options);

            SuiviWookies.Web.Ui.Controllers.WookiesController controller = new(new Core.Services.WookieService(context),
                                                                               new WeaponService(context));
            Assert.NotNull(controller);
        }
    }
}
