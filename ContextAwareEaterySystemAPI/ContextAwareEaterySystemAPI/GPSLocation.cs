using System;
using System.Collections.Generic;
using System.Text;
using ContextAwareEaterySystemAPI.Interfaces;

namespace ContextAwareEaterySystemAPI
{
    public class GPSLocation : Interfaces.IGPSLocation
    {
        #region Methods

        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double getLatitude()
        {
            return Latitude;
        }

        public double getLongitude()
        {
            return Longitude;
        }

        public void setLatitude(double latitude)
        {
            Latitude = latitude;
        }

        public void setLongitude(double longitude)
        {
            Longitude = longitude;
        }


        #endregion

        #region Attributes

        private double Latitude;

        private double Longitude;

        #endregion

    }
}
