using System;
using System.Collections.Generic;
using System.Text;

namespace ContextAwareEaterySystemAPI.Abstract_Classes
{
    public abstract class Preference
    {
        /*
         *  Component, defines the interface for objects that can have responsibilities added to them dynamically.
         */

        #region Methods

        public abstract void setRestaurantType(string RestaurantType);

        public abstract void setCuisineType(string cuisineType);

        public abstract void setFoodType(string foodType);

        #endregion
    }
}
