using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebApp.Controllers;
namespace WebApp.Tests.Controllers
{
    [TestClass]
    public class WebServiceTest
    {
        private readonly WebService1 w = new WebService1();

        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void sumTest()
        {
            Assert.IsTrue(w.getSum(1, 2) == 3);
        }

        [TestMethod]
        public void substractionTest()
        {
            Assert.IsTrue(w.getSubstraction(5, 4) == 1);
        }

        
        [TestMethod]
        public void multiplieTest()
        {
            Assert.IsTrue(w.getMultiplie(1, 5) == 5);
        }
    }
}
