using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextAwareEaterySystemAPI;

namespace Recommendation.Test
{
    [TestClass]
    public class RecommendationTests
    {
        [TestMethod]
        public void Test_GetRestaurantName()
        {
            // Arrange
            string expected = "The CodFather";
            RecommendedRestaurant RR = new RecommendedRestaurant("The CodFather", "Takeaway", "Fish & Chips", "10 Renfield Road", 1.1, 5, 7);

            // Act
            string actual = RR.getRestaurantName();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetRestaurantType()
        {
            // Arrange
            string expected = "SitIn";
            RecommendedRestaurant RR = new RecommendedRestaurant("Imperial Duck","SitIn","Chinese Curry","4 Vine Drove",0.2,0.1,4);

            // Act
            string actual = RR.getRestaurantType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetCuisineType()
        {
            // Arrange
            string expected = "StirFry";
            RecommendedRestaurant RR = new RecommendedRestaurant("Bamboo Star","Takeaway","StirFry","5 Mossy Lane",2,0.9,1);

            // Act
            string actual = RR.getCuisineType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAVGNumberPeople()
        {
            // Arrange
            int expected = 6;
            RecommendedRestaurant RR = new RecommendedRestaurant("The Depot","SitIn","Mince Pie",6,3,"62 Wharton Court", 4,5,2);

            // Act
            int actual = RR.getAVGPeople();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetCurrentNumPeople()
        {
            // Arrange
            int expected = 10;
            RecommendedRestaurant RR = new RecommendedRestaurant("The Spaghetti House", "SitIn","Carbonara",15,10,"7 Vaughan Village", 1,0.5,1);

            // Act
            int actual = RR.getCurrentNumPeople();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAddress()
        {
            // Arrange
            string expected = "125 Drury Haven";
            RecommendedRestaurant RR = new RecommendedRestaurant("Spiced Hook","Takeaway","Fried Chicken",19,1,"125 Drury Haven", 3,1.2,0);

            // Act
            string actual = RR.getAddress();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetDistance()
        {
            // Arrange
            double expected = 4;
            RecommendedRestaurant RR = new RecommendedRestaurant("Sepp's Indian Grill", "Takeaway","Bhuna",12,15,"52 Calcot Lane",4,10,6);

            // Act
            double actual = RR.getDistance();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetRouteTime()
        {
            // Arrange
            double expected = 5.5;
            RecommendedRestaurant RR = new RecommendedRestaurant("Roots","SitIn","Steak",7,10,"22 Latimer Lodge",8,5.5,4);

            // Act
            double actual = RR.getRouteTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetWaitTime()
        {
            // Arrange
            double expected = 9;
            RecommendedRestaurant RR = new RecommendedRestaurant("Great Wok", "Takeaway","Curry",5,5,"1 Talbot Hollies", 3,2,9);

            // Act
            double actual = RR.getWaitTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetRestaurantName()
        {
            // Arrange
            string expected = "The CodFather";
            RecommendedRestaurant RR = new RecommendedRestaurant("", "Takeaway", "Fish & Chips", "10 Renfield Road", 1.1, 5, 7);

            // Act
            RR.setRestaurantName("The CodFather");
            string actual = RR.getRestaurantName();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetRestaurantType()
        {
            // Arrange
            string expected = "SitIn";
            RecommendedRestaurant RR = new RecommendedRestaurant("Imperial Duck", "", "Chinese Curry", "4 Vine Drove", 0.2, 0.1, 4);

            // Act
            RR.setResturauntType("SitIn");
            string actual = RR.getRestaurantType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetCuisineType()
        {
            // Arrange
            string expected = "StirFry";
            RecommendedRestaurant RR = new RecommendedRestaurant("Bamboo Star", "Takeaway", "", "5 Mossy Lane", 2, 0.9, 1);

            // Act
            RR.setCuisineType("StirFry");
            string actual = RR.getCuisineType();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetAVGNumberPeople()
        {
            // Arrange
            int expected = 6;
            RecommendedRestaurant RR = new RecommendedRestaurant("The Depot", "SitIn", "Mince Pie", 0, 3, "62 Wharton Court", 4, 5, 2);

            // Act
            RR.setAVGPeople(6);
            int actual = RR.getAVGPeople();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetCurrentNumPeople()
        {
            // Arrange
            int expected = 10;
            RecommendedRestaurant RR = new RecommendedRestaurant("The Spaghetti House", "SitIn", "Carbonara", 15, 0, "7 Vaughan Village", 1, 0.5, 1);

            // Act
            RR.setCurrentNumPeople(10);
            int actual = RR.getCurrentNumPeople();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetAddress()
        {
            // Arrange
            string expected = "125 Drury Haven";
            RecommendedRestaurant RR = new RecommendedRestaurant("Spiced Hook", "Takeaway", "Fried Chicken", 19, 1, "", 3, 1.2, 0);

            // Act
            RR.setAddress("125 Drury Haven");
            string actual = RR.getAddress();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetDistance()
        {
            // Arrange
            double expected = 4;
            RecommendedRestaurant RR = new RecommendedRestaurant("Sepp's Indian Grill", "Takeaway", "Bhuna", 12, 15, "52 Calcot Lane", 0, 10, 6);

            // Act
            RR.setDistance(4);
            double actual = RR.getDistance();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetRouteTime()
        {
            // Arrange
            double expected = 5.5;
            RecommendedRestaurant RR = new RecommendedRestaurant("Roots", "SitIn", "Steak", 7, 10, "22 Latimer Lodge", 8, 0, 4);

            // Act
            RR.setRouteTime(5.5);
            double actual = RR.getRouteTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SetWaitTime()
        {
            // Arrange
            double expected = 9;
            RecommendedRestaurant RR = new RecommendedRestaurant("Great Wok", "Takeaway", "Curry", 5, 5, "1 Talbot Hollies", 3, 2, 0);

            // Act
            RR.setWaitTime(9);
            double actual = RR.getWaitTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
