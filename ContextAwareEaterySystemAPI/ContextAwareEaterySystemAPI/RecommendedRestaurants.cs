using System;
using System.Collections.Generic;
using System.Text;
using ContextAwareEaterySystemAPI;

namespace ContextAwareEaterySystemAPI
{
    public class RecommendedRestaurant : Abstract_Classes.Recommendation
    {
        #region Methods

        public RecommendedRestaurant(string resturauntName, string resturuantType, string cuisisneType, string resurauntLocation, double distance, double routeTime, double waitTime) : this(resturauntName, resturuantType, cuisisneType, 0, 0, resurauntLocation, distance, routeTime, waitTime)
        {
            //No analitical data available, create recommendation with no statistical data (AVG / Current no of people)
        }

        public RecommendedRestaurant(string resturauntName, string resturuantType, string cuisisneType, int averagePeople, int cNumPeople, string resurauntLocation, double distance, double routeTime, double waitTime)
        {
            setRestaurantName(resturauntName);
            setResturauntType(resturuantType);
            setCuisineType(cuisisneType);
            setAVGPeople(averagePeople);
            setCurrentNumPeople(cNumPeople);
            setAddress(resurauntLocation);
            setDistance(distance);
            setRouteTime(routeTime);
            setWaitTime(waitTime);
        }

        #endregion
    }
}
