using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    
    public class CashTransferTests
    {
        [TestMethod]
        public void CashTransferForm_Should_LoadSuccessfully()
        {
            CashTransfer form = new CashTransfer();
            Assert.IsNotNull(form);
        }
    }
}