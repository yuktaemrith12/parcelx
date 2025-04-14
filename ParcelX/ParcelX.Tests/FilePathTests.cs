using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
namespace PostalCW.Tests
{
    [TestClass]
    public class FilePathTests
    {
        [TestMethod]
        public void FilePathForm_Should_LoadSuccessfully()
        {
            FilePath form = new FilePath();
            Assert.IsNotNull(form);
        }
    }
}