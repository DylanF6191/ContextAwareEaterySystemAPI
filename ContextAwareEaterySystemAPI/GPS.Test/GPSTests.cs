using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextAwareEaterySystemAPI;

namespace GPS.Test
{
    [TestClass]
    public class GPSTests
    {
        [TestMethod]
        public void Test_GetLatitude()
        {
            // Arrange
            double expected = 57.3;
            GPSLocation GPSL = new GPSLocation(57.3,-4.1);

            // Act
            double actual = GPSL.getLatitude();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetLongitude()
        {
            // Arrange
            double expected = -4.1;
            GPSLocation GPSL = new GPSLocation(57.3, -4.1);

            // Act
            double actual = GPSL.getLongitude();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetLatitude()
        {
            // Arrange
            double expected = 66.6;
            GPSLocation GPSL = new GPSLocation(0, 10);

            // Act
            GPSL.setLatitude(66.6);
            double actual = GPSL.getLatitude();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetLongitude()
        {
            // Arrange
            double expected = -1.66;
            GPSLocation GPSL = new GPSLocation(52.4, 0);

            // Act
            GPSL.setLongitude(-1.66);
            double actual = GPSL.getLongitude();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
