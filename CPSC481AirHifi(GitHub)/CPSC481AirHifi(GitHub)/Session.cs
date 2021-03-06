﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481AirHifi_GitHub_
{
    public class Session
    {
        private Data data = new Data();
        private Stack<string> screenhistory = new Stack<string>();
        private string busroute = "Route1A";
        private string hotel;
        private string hoteldescription;
        private string destination;

        public void setdestination(string selection)
        {
            destination = selection;
        }

        public string getdestination()
        {
            return destination;
        }
        public void sethotel(string selection)
        {
            hotel = selection;
        }

        public string gethoteldescription()
        {
            return hoteldescription;
        }

        public void sethoteldescription(string selection)
        {
            hoteldescription = selection;
        }

        public string gethotel()
        {
            return hotel;
        }

        public void setbusroute(string selection)
        {
            busroute = selection;
        }

        public string getbusroute()
        {
            return busroute;
        }

        public void setpreviousscreen(string currentscreen)
        {
            screenhistory.Push(currentscreen);
        }

        public string getpreviousscreen()
        {
            return screenhistory.Pop();
        }

        public void poppreviousscreen()
        {
            screenhistory.Pop();
        }

        public string getHotelReviews()
        {
            switch (hotel)
            {
                case "Hotel Arts":
                    return data.getHotelArtsReviews();
                case "Hotel Blue":
                    return data.getHotelBlueReviews();
                case "The Purple Hotel":
                    return data.getThePurpleHotelReviews();
            }
            return "";

        }

        public void addHotelReview(string review)
        {
            switch (hotel)
            {
                case "Hotel Arts":
                    data.addReviewHotelArts(review);
                    break;
                case "Hotel Blue":
                    data.addReviewHotelBlue(review);
                    break;
                case "The Purple Hotel":
                    data.addReviewThePurpleHotel(review);
                    break;
            }

        }
    }
}