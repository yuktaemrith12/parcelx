using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void ClientForm_Should_LoadSuccessfully()
        {
            Clients form = new Clients();
            Assert.IsNotNull(form);
        }
    }
}