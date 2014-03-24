using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPSC481AirHifi_GitHub_
{
    /// <summary>
    /// Interaction logic for PedestrianDirections.xaml
    /// </summary>
    public partial class PedestrianDirections : UserControl, ISwitchable
    {
        private Session session;

        public PedestrianDirections()
        {
            InitializeComponent();
        }

        #region Loaders
        public void Destination (object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = "To: " + session.getdestination();
        }

        public void TitleLoader(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = "Directions to " + session.getdestination() + " on Foot";
        }

        public void DirectionsLoader(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            switch (session.getdestination())
            {
                case "Hotel Arts":
                    label.Content = "Cross 16 Avenue and follow the pedestrian path \r\n \r\nTake a right on 17 Avenue and follow down to the intersection \r\n \r\nCross both 17 Avenue and 13 Street NW at the intersection \r\n \r\nFollow 17 Avenue \r\n \r\nYou are at your destination";
                    break;
                case "Hotel Blue":
                    label.Content = "Estimated time of arrival: 5 minutes";
                    break;
                case "The Purple Hotel":
                    label.Content = "Estimated time of arrival: 16 minutes";
                    break;
            }
        }

        public void TaxiTime(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            switch (session.getdestination())
            {
                case "Hotel Arts":
                    label.Content = "Estimated time of arrival: 2 minutes";
                    break;
                case "Hotel Blue":
                    label.Content = "Estimated time of arrival: 5 minutes";
                    break;
                case "The Purple Hotel":
                    label.Content = "Estimated time of arrival: 16 minutes";
                    break;
            }
        }

         public void TransitTime(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            switch (session.getdestination())
            {
                case "Hotel Arts":
                    label.Content = "Estimated time of arrival: 3 minutes";
                    break;
                case "Hotel Blue":
                    label.Content = "Estimated time of arrival: 11 minutes";
                    break;
                case "The Purple Hotel":
                    label.Content = "Estimated time of arrival: 22 minutes";
                    break;
            }
        }

        public void FootTime(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            switch (session.getdestination())
            {
                case "Hotel Arts":
                    label.Content = "Estimated time of arrival: 2 minutes";
                    break;
                case "Hotel Blue":
                    label.Content = "Estimated time of arrival: 32 minutes";
                    break;
                case "The Purple Hotel":
                    label.Content = "Estimated time of arrival: 1 h 23 m";
                    break;
            }
        }
        #endregion

        #region Window Transitions
        private void BackButtonPressed(object sender, RoutedEventArgs e)
        {
            var back = new Back();
            back.StepBack(session);
        }

        private void HomeButtonPressed(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LaunchScreen(), session);
        }
        #endregion

        #region ISwitchable Members
        public void UtilizeState(Session state)
        {
            session = state;
        }
        #endregion

    }
}