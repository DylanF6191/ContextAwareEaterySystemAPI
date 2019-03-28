using System;
using System.Collections.Generic;
using System.Text;

namespace ContextAwareEaterySystemAPI.Interfaces
{
    public interface IGPSLocation
    {
        double getLatitude();

        double getLongitude();

        void setLatitude(double latitude);

        void setLongitude(double longitude);
    }
}
