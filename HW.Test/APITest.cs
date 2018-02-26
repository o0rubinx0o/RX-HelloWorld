using HW.API.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW.Test
{
    [TestClass]
    public class ApiTest
    {
        private const string ExpectedResult = "Hello World";

        [TestMethod]
        public void ConsoleMessageRepositoryTest()
        {
            var repo = new ConsoleMessageRepository();
            var message = repo.GetMessage();

            Assert.AreEqual(message, ExpectedResult);
        }

        [TestMethod]
        public void MobileMessageRepositoryTest()
        {
            var repo = new MobileMessageRepository();
            var message = repo.GetMessage();

            Assert.AreEqual(message, ExpectedResult);
        }

        [TestMethod]
        public void WebMessageRepositoryTest()
        {
            var repo = new WebMessageRepository();
            var message = repo.GetMessage();

            Assert.AreEqual(message, ExpectedResult);
        }
    }
}
