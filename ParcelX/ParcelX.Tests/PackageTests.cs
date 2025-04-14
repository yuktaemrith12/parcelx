using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    public class PackageTests
    {
        [TestMethod]
        public void PackageForm_Should_LoadSuccessfully()
        {
            Package form = new Package();
            Assert.IsNotNull(form);
        }
    }
}