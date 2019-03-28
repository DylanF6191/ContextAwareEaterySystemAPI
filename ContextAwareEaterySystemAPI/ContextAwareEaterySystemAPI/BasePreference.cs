namespace ContextAwareEaterySystemAPI
{
    public class BasePreference : Abstract_Classes.Preference
    {
        /*
         *   Concrete Component Class, defines an object to which additional responsibilities can be attached.
         */

        #region Methods

        public BasePreference(string cuisineType, string foodType, string RestaurantType)
        {
            CuisineType = cuisineType;
            FoodType = foodType;
            ResurauntType = RestaurantType;
        }

        public string getCuisineType()
        {
            return CuisineType;
        }

        public string getFoodType()
        {
            return FoodType;
        }

        public string getRestaurantType()
        {
            return ResurauntType;
        }

        public override void setCuisineType(string cuisineType)
        {
            CuisineType = cuisineType;
        }

        public override void setFoodType(string foodType)
        {
            FoodType = foodType;
        }

        public override void setRestaurantType(string RestaurantType)
        {
            ResurauntType = RestaurantType;
        }

        #endregion

        #region Attributes

        private string CuisineType;

        private string FoodType;

        private string ResurauntType;

        #endregion
    }
}
