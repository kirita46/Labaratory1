using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetworkDevicesApp;

namespace NetworkDevicesApp.Tests
{
    [TestClass]
    public class NetworkDeviceTests
    {
        [TestMethod]
        public void NetworkDevice_ShouldInitializeCorrectly()
        {
            // Arrange
            var device = new NetworkDevice("ModelX", "ManufacturerY");

            // Act & Assert
            Assert.AreEqual("ModelX", device.Model);
            Assert.AreEqual("ManufacturerY", device.Manufacturer);
        }

        [TestMethod]
        public void NetworkDevice_ShouldSetAndGetPropertiesCorrectly()
        {
            // Arrange
            var device = new NetworkDevice();

            // Act
            device.Model = "NewModel";
            device.Manufacturer = "NewManufacturer";

            // Assert
            Assert.AreEqual("NewModel", device.Model);
            Assert.AreEqual("NewManufacturer", device.Manufacturer);
        }
    }
}