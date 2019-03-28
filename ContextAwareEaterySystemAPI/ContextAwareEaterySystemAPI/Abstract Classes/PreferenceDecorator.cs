using System;
using System.Collections.Generic;
using System.Text;
using ContextAwareEaterySystemAPI;

namespace ContextAwareEaterySystemAPI.Abstract_Classes
{
    public abstract class PreferenceDecorator : Abstract_Classes.Preference
    {

        /*
         *  Decorator,  maintains a reference to a Component object and defines an interface that conforms to Component's interface.
         */

        #region Methods

        public PreferenceDecorator(Abstract_Classes.Preference newPreference)
        {
            tempPreference = newPreference;
        }

        public override void setCuisineType(string cuisineType)
        {
            tempPreference.setCuisineType(cuisineType);
        }

        public override void setFoodType(string foodType)
        {
            tempPreference.setFoodType(foodType);
        }

        public override void setRestaurantType(string RestaurantType)
        {
            tempPreference.setRestaurantType(RestaurantType);
        }

        #endregion

        #region Attributes

        protected Abstract_Classes.Preference tempPreference;

        #endregion
    }
}
