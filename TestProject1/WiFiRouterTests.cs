using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetworkDevicesApp;

namespace NetworkDevicesApp.Tests
{
    [TestClass]
    public class WiFiRouterTests
    {
        [TestMethod]
        public void WiFiRouter_ShouldInitializeCorrectly()
        {
            // Arrange
            var router = new WiFiRouter("RouterModel", "RouterManufacturer", 100, 4);

            // Act & Assert
            Assert.AreEqual("RouterModel", router.Model);
            Assert.AreEqual("RouterManufacturer", router.Manufacturer);
            Assert.AreEqual(100, router.MaxSpeed);
            Assert.AreEqual(4, router.NumAntennas);
        }

        [TestMethod]
        public void WiFiRouter_ShouldSetAndGetPropertiesCorrectly()
        {
            // Arrange
            var router = new WiFiRouter();

            // Act
            router.MaxSpeed = 200;
            router.NumAntennas = 6;

            // Assert
            Assert.AreEqual(200, router.MaxSpeed);
            Assert.AreEqual(6, router.NumAntennas);
        }
    }
}