using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetworkDevicesApp;

namespace NetworkDevicesApp.Tests
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void Switch_ShouldInitializeCorrectly()
        {
            // Arrange
            var switchDevice = new Switch("SwitchModel", "SwitchManufacturer", 24, true);

            // Act & Assert
            Assert.AreEqual("SwitchModel", switchDevice.Model);
            Assert.AreEqual("SwitchManufacturer", switchDevice.Manufacturer);
            Assert.AreEqual(24, switchDevice.NumPorts);
            Assert.IsTrue(switchDevice.IsManaged);
        }

        [TestMethod]
        public void Switch_ShouldSetAndGetPropertiesCorrectly()
        {
            // Arrange
            var switchDevice = new Switch();

            // Act
            switchDevice.NumPorts = 48;
            switchDevice.IsManaged = false;

            // Assert
            Assert.AreEqual(48, switchDevice.NumPorts);
            Assert.IsFalse(switchDevice.IsManaged);
        }
    }
}