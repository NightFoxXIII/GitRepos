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
    /// Interaction logic for RouteSearchSplashScreen.xaml
    /// </summary>
    public partial class RouteSearchSplashScreen : UserControl, ISwitchable
    {
        private Session session;
        List<string> comboboxlist = new List<string>(new String[] { "Hotel Arts", "Hotel Blue", "The Purple Hotel" });

        public RouteSearchSplashScreen()
        {
            InitializeComponent();
        }

        #region Loaders
        private void LoadSearchCombobox(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = comboboxlist;
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

        private void Search(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            session.setdestination(value);
            session.setpreviousscreen("RouteSearchSplashScreen");
            Switcher.Switch(new RouteSearch(), session);
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