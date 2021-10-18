using System;
using Xunit;

namespace SuiviWookies.Tests.Web
{
    public class WookieUnitTest
    {
        [Fact]
        public void ShouldRun()
        {
            SuiviWookies.Web.Ui.Controllers.WookiesController controller = new(new Core.Services.WookieService());
            Assert.NotNull(controller);
        }
    }
}
