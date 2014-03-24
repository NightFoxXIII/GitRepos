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
    /// Interaction logic for PublicTransitDirections.xaml
    /// </summary>
    public partial class PublicTransitDirections : UserControl, ISwitchable
    {
        private Session session;

        public PublicTransitDirections()
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
            label.Content = "Public Transit Scheduals";
        }

        public void DirectionsLoader(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = "Sorry, but our service is currently down. All of our tiny penguins when on strike.";
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

        private void PedestrianDirections(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PedestrianDirections(), session);
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