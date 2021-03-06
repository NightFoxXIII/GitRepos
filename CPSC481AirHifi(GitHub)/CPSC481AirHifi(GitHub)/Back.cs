﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481AirHifi_GitHub_
{
    class Back 
    {
        public void StepBack(Session session)
        {
            switch (session.getpreviousscreen()){
                case "hotelscreen":
                    Switcher.Switch(new HotelSelector(), session);
                    break;
                case "RouteSearchSplashScreen":
                    Switcher.Switch(new RouteSearchSplashScreen(), session);
                    break;
                case "launchscreen":
                    Switcher.Switch(new LaunchScreen(), session);
                    break;
                case "":
                    Switcher.Switch(new LaunchScreen(), session);
                    break;
                case "busselectionscreen":
                    Switcher.Switch(new BusSelector(), session);
                    break;
                case "RouteSearch":
                    Switcher.Switch(new RouteSearch(), session);
                    break;
                case "foodscreen":
                    Switcher.Switch(new FoodSelector(), session);
                    break;
                case "eventscreen":
                    Switcher.Switch(new EventSelector(), session);
                    break;
                case "hotelreviewsscreen":
                    Switcher.Switch(new HotelReview(), session);
                    break;
            }
        }

    }
}
