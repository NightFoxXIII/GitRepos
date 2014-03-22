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
    /// Interaction logic for BusSelector.xaml
    /// </summary>
    public partial class BusSelector : UserControl, ISwitchable
    {
        private Session session;
        public BusSelector()
        {
            InitializeComponent();
        }

        #region ISwitchable Members
        public void UtilizeState(Session state)
        {
            session = state;
        }

        private void BackButtonPress(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LaunchScreen(), session);
        }

        private void Route1ASelected(object sender, MouseButtonEventArgs e)
        {
            session.setbusroute("Route1A");
            Switcher.Switch(new LaunchScreen(), session);
        }

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

        private void Route1BSelected(object sender, MouseButtonEventArgs e)
        {
            session.setbusroute("Route1B");
            Switcher.Switch(new LaunchScreen(), session);
        }

        private void Route2ASelected(object sender, MouseButtonEventArgs e)
        {
            session.setbusroute("Route2A");
            Switcher.Switch(new LaunchScreen(), session);
        }

        private void Route2BSelected(object sender, MouseButtonEventArgs e)
        {
            session.setbusroute("Route2B");
            Switcher.Switch(new LaunchScreen(), session);
        }
        #endregion
    }
}

