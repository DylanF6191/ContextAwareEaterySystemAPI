using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextAwareEaterySystemAPI;

namespace Preference.Test
{
    [TestClass]
    public class PreferenceTests
    {
        [TestMethod]
        public void Test_GetCuisineType()
        {
            // Arrange
            string expected = "Chinese";
            BasePreference BP = new BasePreference("Chinese", "Curry", "Takeaway");

            // Act
            string actual = BP.getCuisineType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetFoodType()
        {
            // Arrange
            string expected = "Burger";
            BasePreference BP = new BasePreference("American", "Burger", "SitIn");

            // Act
            string actual = BP.getFoodType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetRestaurantType()
        {
            // Arrange
            string expected = "Takeaway";
            BasePreference BP = new BasePreference("Indian", "Kebab", "Takeaway");

            // Act
            string actual = BP.getRestaurantType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllergeyRestrictions()
        {
            // Arrange
            string expected = "Dairy";
            BasePreference BP = new BasePreference("Chip Shop", "Fish and chips", "Takeaway");
            UserPreferences UP = new UserPreferences(BP, "Dairy", "None");

            // Act
            string actual = UP.AllergyRestriction;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetDietaryRestrictions()
        {
            // Arrange
            string expected = "Halal";
            BasePreference BP = new BasePreference("Indian", "Curry", "SitIn");
            UserPreferences UP = new UserPreferences(BP, "Peanuts", "Halal");

            // Act
            string actual = UP.DietRestriction;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetCuisineType()
        {
            // Arrange
            string expected = "Thai";
            BasePreference BP = new BasePreference("", "Fish", "SitIn");

            // Act
            BP.setCuisineType(expected);
            string actual = BP.getCuisineType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetFoodType()
        {
            // Arrange
            string expected = "Fish";
            BasePreference BP = new BasePreference("Thai", "", "SitIn");

            // Act
            BP.setFoodType(expected);
            string actual = BP.getFoodType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetResturauntType()
        {
            // Arrange
            string expected = "SitIn";
            BasePreference BP = new BasePreference("Thai", "Fish", "");

            // Act
            BP.setRestaurantType(expected);
            string actual = BP.getRestaurantType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetAllergeyRestrictions()
        {
            // Arrange  
            string expected = "Nuts";
            BasePreference BP = new BasePreference("Japanese","Sushi","SitIn");
            UserPreferences UP = new UserPreferences(BP, "","None");

            // Act
            UP.AllergyRestriction = "Nuts";
            string actual = UP.AllergyRestriction;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetDietaryRestrictions()
        {
            // Arrange
            string expected = "Kosher";
            BasePreference BP = new BasePreference("American","Roast Pork","SitIn");
            UserPreferences UP = new UserPreferences(BP,"None","");

            // Act
            UP.DietRestriction = "Kosher";
            string actual = UP.DietRestriction;

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
