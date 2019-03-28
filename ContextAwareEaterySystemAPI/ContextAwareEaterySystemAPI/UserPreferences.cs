using System;
using System.Collections.Generic;
using System.Text;
using ContextAwareEaterySystemAPI;
using ContextAwareEaterySystemAPI.Abstract_Classes;
using ContextAwareEaterySystemAPI.Interfaces;

namespace ContextAwareEaterySystemAPI
{
    public class UserPreferences : Abstract_Classes.PreferenceDecorator
    {
        /*
         *  ConcreteDecorator,  adds responsibilities to the component.
         */

        #region Methods

        public UserPreferences(Preference newPreference, string allergyRestriction, string dietRestriction) : base(newPreference)
        {
            AllergyRestriction = allergyRestriction;
            DietRestriction = dietRestriction;
        }

        #endregion

        #region Attributes

        public string AllergyRestriction { get; set; } //User Allergy Restrictions

        public string DietRestriction { get; set; } //User Dietary Restrictions

        #endregion
    }
}
