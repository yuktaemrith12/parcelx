using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    public class PostmanTests
    {
        [TestMethod]
        public void PostmanForm_Should_LoadSuccessfully()
        {
            Postman form = new Postman();
            Assert.IsNotNull(form);
        }
    }
}