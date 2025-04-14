using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DatabaseHasPostmanData_ShouldReturnBool()
        {
            bool result = Program.DatabaseHasPostmanData();
            Assert.IsInstanceOfType(result, typeof(bool));
        }
    }
}