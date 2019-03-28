using System;
using System.Collections.Generic;
using System.Text;

namespace ContextAwareEaterySystemAPI.Abstract_Classes
{
    public abstract class Recommendation
    {
        #region Methods

        public string getRestaurantName()
        {
            return RestaurantName;
        }

        public string getRestaurantType()
        {
            return ResturauntType;
        }

        public string getCuisineType()
        {
            return CuisineType;
        }

        public int getAVGPeople()
        {
            return AVGPeople;
        }

        public int getCurrentNumPeople()
        {
            return CurrentNumPeople;
        }

        public string getAddress()
        {
            return Address;
        }

        public double getDistance()
        {
            return Distance;
        }

        public double getRouteTime()
        {
            return RouteTime;
        }

        public double getWaitTime()
        {
            return WaitTime;
        }

        public void setRestaurantName(string resurauntName)
        {
            RestaurantName = resurauntName;
        }

        public void setResturauntType(string resturauntType)
        {
            ResturauntType = resturauntType;
        }

        public void setCuisineType(string cuisineType)
        {
            CuisineType = cuisineType;
        }

        public void setAVGPeople(int avgPeople)
        {
            AVGPeople = avgPeople;
        }

        public void setCurrentNumPeople(int currentNumPeople)
        {
            CurrentNumPeople = currentNumPeople;
        }

        public void setAddress(string address)
        {
            Address = address;
        }

        public void setDistance(double distance)
        {
            Distance = distance;
        }

        public void setRouteTime(double routeTime)
        {
            RouteTime = routeTime;
        }

        public void setWaitTime(double waitTime)
        {
            WaitTime = waitTime;
        }

        #endregion

        #region Attributes

        private string RestaurantName;

        private string ResturauntType;

        private string CuisineType;

        private int AVGPeople;

        private int CurrentNumPeople;

        private string Address;

        private double Distance;

        private double RouteTime;

        private double WaitTime;

        #endregion
    }
}
