using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481AirHifi_GitHub_
{
    class Data
    {
        private string HotelArtsReviews = "I am the bannana man \r\n \r\nThis Hotel has all the tiny penguins \r\n \r\nI ate a whole puppy this one time \r\n \r\nI hope you enjoy roaches, cause this hotel sells them for cheap";
        private string HotelBlueReviews = "I am the bannana man \r\n \r\nThis Hotel has all the tiny penguins \r\n \r\nI ate a whole puppy this one time \r\n \r\nI hope you enjoy roaches, cause this hotel sells them for cheap";
        private string ThePurpleHotelReviews = "I am the bannana man \r\n \r\nThis Hotel has all the tiny penguins \r\n \r\nI ate a whole puppy this one time \r\n \r\nI hope you enjoy roaches, cause this hotel sells them for cheap";

        public string getHotelArtsReviews()
        {
            return HotelArtsReviews;
        }

        public string getHotelBlueReviews()
        {
            return HotelBlueReviews;
        }

        public string getThePurpleHotelReviews()
        {
            return ThePurpleHotelReviews;
        }

        public void addReviewHotelArts(string review)
        {
            HotelArtsReviews = HotelArtsReviews + "\r\n \r\n" + review;
        }

        public void addReviewHotelBlue(string review)
        {
            HotelBlueReviews = HotelBlueReviews + "\r\n \r\n" + review;
        }

        public void addReviewThePurpleHotel(string review)
        {
            ThePurpleHotelReviews = ThePurpleHotelReviews = "\r\n \r\n" + review;
        }
    }
}
