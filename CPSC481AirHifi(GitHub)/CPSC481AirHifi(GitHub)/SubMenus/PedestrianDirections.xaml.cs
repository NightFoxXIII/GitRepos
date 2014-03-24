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
                    label.Content = "Cross 24th Avenue NE and follow the pedestrian path \r\n \r\nTake a right on 25th Avenue NE and follow it down to the intersection \r\n \r\nCross both 25th Avenue NE and 4th Street NE at the intersection \r\n \r\nFollow 25th Avenue NE \r\n \r\nYou are at your destination";
                    break;
                case "Hotel Blue":
                    label.Content = "Follow 25th Avenue NE until 4th Street NE \r\n \r\nTake a right onto 4th Street NE \r\n \r\nFollow 4th Street NE up until 24th Avenue NE \r\n \r\nCross 24th Avenue NE at the intersection \r\n \r\nFollow 4th Street NE up until 23th Avenue NE \r\n \r\nCross 23th Avenue NE at the intersetion \r\n \r\nYour destination is now allong the right side of Winston Heights Park";
                    break;
                case "The Purple Hotel":
                    label.Content = "Follow the access alley down to 1st Street NW \r\n \r\nCross 1st Steet NW at the intersection and take a left \r\n \r\nFollow 1st Street NW down to 24th Avenue NW \r\n \r\nTake a right at the intersection \r\n \r\nFollow 24th Avenue NW down to 25th Avenue NW \r\n \r\nTake a right on 25th Avenue NW \r\n \r\nFollow 25th Avenue down to your destination";
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

        #region Mouseover Events
        private void BorderCovered(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.BorderThickness = new Thickness(1);
        }

        private void BorderUncovered(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.BorderThickness = new Thickness(0);
        }
        #endregion

        #region Window Transitions
        private void BackButtonPressed(object sender, RoutedEventArgs e)
        {
            var back = new Back();
            back.StepBack(session);
        }

        private void PublicTransitDirections(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PublicTransitDirections(), session);
        }

        private void CabDirections(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CabCompany(), session);
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