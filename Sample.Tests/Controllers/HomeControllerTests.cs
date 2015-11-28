using NUnit.Framework;
using Sample.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sample.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Home_controller_returns_view()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.That(result, Is.InstanceOf<ActionResult>());
        }
    }
}
