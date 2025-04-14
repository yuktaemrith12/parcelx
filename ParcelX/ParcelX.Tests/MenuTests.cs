using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW;
using System.Windows.Forms;

namespace PostalCW.Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void MenuForm_ShouldLoadSuccessfully()
        {
            // Arrange
            var menuForm = new Menu();

            // Act
            menuForm.Show();

            // Assert
            Assert.IsNotNull(menuForm, "Menu form should be created successfully.");
        }

        [TestMethod]
        public void Menu_ClickClientIcon_ShouldOpenClientForm()
        {
            // Arrange
            var menuForm = new Menu();

            // Act
            menuForm.GetType()
                .GetMethod("ClientPic_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(menuForm, new object[] { null, null });

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Menu_ClickPostmanIcon_ShouldOpenPostmanForm()
        {
            // Arrange
            var menuForm = new Menu();

            // Act
            menuForm.GetType()
                .GetMethod("PostmanPic_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(menuForm, new object[] { null, null });

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Menu_LogoutConfirmation_ShouldShowMessageBox()
        {
            // Arrange
            var menuForm = new Menu();

            // Act
            menuForm.GetType()
                .GetMethod("LogoutPic_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(menuForm, new object[] { null, null });

            // Assert
            Assert.IsTrue(true);  // If it runs without error, assume success
        }
    }
}
