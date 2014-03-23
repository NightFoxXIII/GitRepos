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
using System.Windows.Threading;

namespace CPSC481AirHifi_GitHub_
{
    /// <summary>
    /// Interaction logic for HotelSelector.xaml
    /// </summary>
    public partial class HotelSelector : UserControl, ISwitchable
    {
        private Session session;
        private int i = 0;

        public HotelSelector()
        {
            InitializeComponent();
            DispatcherTimer dispatchertimer = new DispatcherTimer();

            dispatchertimer.Tick += new EventHandler(dispatchertimer_Tick);
            dispatchertimer.Interval = new TimeSpan(0, 0, 2);
            dispatchertimer.Start();
        }

        #region Image Timer Stuff

        private void dispatchertimer_Tick(object sender, EventArgs e)
        {
            if (i >= 3)
                i = 0;
            i++;

            taxi_ads.Source = (ImageSource)new BitmapImage(
                new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/taxi_" + (i % 100) + ".jpg", UriKind.RelativeOrAbsolute));
        }

        private void taxi_ads_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        #endregion

        #region Click Events
        public void HotelASelected(object sender, RoutedEventArgs e)
        {
            //some actions
        }

        public void HotelBSelected(object sender, RoutedEventArgs e)
        {
            //some actions
        }

        public void HotelCSelected(object sender, RoutedEventArgs e)
        {
            //some actions
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

        private void LabelCovered(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            label.FontSize = 14;
        }

        private void LabelUncovered(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            label.FontSize = 12;
        }
        #endregion

        #region Loaders
        private void BusBoxLoaded(object sender, RoutedEventArgs e)
        {
            var content = sender as Border;
            switch (session.getbusroute())
            {
                case "Route1A":
                    content.Child = new Route1A();
                    break;
                case "Route1B":
                    content.Child = new Route1B();
                    break;
                case "Route2A":
                    content.Child = new Route2A();
                    break;
                case "Route2B":
                    content.Child = new Route2B();
                    break;
            }

        }

        private void GreyhoundBoxLoaded(object sender, RoutedEventArgs e)
        {
            var content = sender as Border;
            content.Child = new DefaultGreyhoundRoute();
        }
        #endregion

        #region Window Transitions
        private void BackButtonPress(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LaunchScreen(), session);
        }

        private void BusSelectionChanged(object sender, RoutedEventArgs e)
        {
            session.setpreviousscreen("launchscreen");
            Switcher.Switch(new BusSelector(), session);
        }

        private void HotelSearch(object sender, RoutedEventArgs e)
        {
            session.setpreviousscreen("launchscreen");
            Switcher.Switch(new HotelSelector(), session);
        }

        private void FoodSearch(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void EventSearch(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void DirectionsSearch(object sender, RoutedEventArgs e)
        {
            session.setpreviousscreen("launchscreen");
            Switcher.Switch(new RouteSearchSplashScreen(), session);
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
