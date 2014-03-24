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
    /// Interaction logic for LaunchScreen.xaml
    /// </summary>
    public partial class LaunchScreen : UserControl, ISwitchable
    {
        private Session session = new Session();
        private int i = 0;

        #region Image Timer Stuff
        public LaunchScreen()
        {
            InitializeComponent();
            DispatcherTimer dispatchertimer = new DispatcherTimer();

            dispatchertimer.Tick += new EventHandler(dispatchertimer_Tick);
            dispatchertimer.Interval = new TimeSpan(0, 0, 2);
            dispatchertimer.Start();
        }

        private void dispatchertimer_Tick(object sender, EventArgs e)
        {
            if (i >= 3)
                i = 0;
            i++;
            image_weather1.Source = (ImageSource)new BitmapImage(
                new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Weather/weat_img" + (i % 100) + ".png", UriKind.RelativeOrAbsolute));

            taxi_ads.Source = (ImageSource)new BitmapImage(
                new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/taxi_" + (i % 100) + ".jpg", UriKind.RelativeOrAbsolute));

           image_events.Source = (ImageSource)new BitmapImage(
                new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Events/event" + (i % 100) + ".jpg", UriKind.RelativeOrAbsolute));
        }

        private void taxi_ads_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

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
                    content.BorderBrush = new BrushConverter().ConvertFromString("#FFF78080") as SolidColorBrush;
                    break;
                case "Route1B":
                    content.Child = new Route1B();
                    content.BorderBrush = new BrushConverter().ConvertFromString("#FFEEE97B") as SolidColorBrush;
                    break;
                case "Route2A":
                    content.Child = new Route2A();
                    content.BorderBrush = new BrushConverter().ConvertFromString("#FF8FE676") as SolidColorBrush;
                    break;
                case "Route2B":
                    content.Child = new Route2B();
                    content.BorderBrush = new BrushConverter().ConvertFromString("#FF6891E6") as SolidColorBrush;
                    break;
            }

        }

        private void GreyhoundBoxLoaded(object sender, RoutedEventArgs e)
        {
            var content = sender as Border;
            content.Child = new DefaultGreyhoundRoute();
        }

        public void MapLoader(object sender, RoutedEventArgs e)
        {
            var image = sender as Image;
            switch (session.gethotel())
            {
                case "Hotel Arts":
                    switch (session.getbusroute()){
                        case "Route1A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/red and hotel 1.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route1B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/yellow and hotel 1.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/green and hotel 1.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/blue and hotel 1.png", UriKind.RelativeOrAbsolute));
                            break;
                    }
                    break;
                case "Hotel Blue":
                    switch (session.getbusroute()){
                        case "Route1A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/red and hotel 2.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route1B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/yellow and hotel 2.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/green and hotel 2.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/blue and hotel 2.png", UriKind.RelativeOrAbsolute));
                            break;
                    }
                    break;
                case "The Purple Hotel":
                    switch (session.getbusroute()){
                        case "Route1A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/red and hotel 3.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route1B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/yellow and hotel 3.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/green and hotel 3.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/blue and hotel 3.png", UriKind.RelativeOrAbsolute));
                            break;
                    }
                    break;
                case null:
                    switch (session.getbusroute())
                    {
                        case "Route1A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/red route.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route1B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/yellow route.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2A":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/green route.png", UriKind.RelativeOrAbsolute));
                            break;
                        case "Route2B":
                            image.Source = (ImageSource)new BitmapImage(new Uri("/CPSC481AirHifi%28GitHub%29;component/Images/Maps/blue route.png", UriKind.RelativeOrAbsolute));
                            break;
                    }
                    break;
            }
        }
        #endregion

        #region Window Transitions
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
