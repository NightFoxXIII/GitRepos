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

        List<string> comboboxlist = new List<string>(new String[] { "ShortRoute", "MediumRoute", "LongRoute" });
        private Session session = new Session();
        private int i = 0;


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
        }

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

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = comboboxlist;
        }

        private void BusSelectionChanged(object sender, RoutedEventArgs e)
        {
            session.setpreviousscreen("launchscreen");
            Switcher.Switch(new BusSelector(), session);
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            //The code to set the direction searched should be here
            session.setpreviousscreen("launchscreen");
            Switcher.Switch(new RouteSearch(), session); 
        }

        private void taxi_ads_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        #region ISwitchable Members
        public void UtilizeState(Session state)
        {
            session = state;
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
