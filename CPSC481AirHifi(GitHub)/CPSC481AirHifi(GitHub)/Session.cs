using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481AirHifi_GitHub_
{
    public class Session
    {
        private string previousscreen;
        private string busroute = "Route1A";
        private string hotel;

        public void sethotel(string selection)
        {
            hotel = selection;
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
            previousscreen = currentscreen;
        }

        public string getpreviousscreen()
        {
            return previousscreen;
        }
    }
}
