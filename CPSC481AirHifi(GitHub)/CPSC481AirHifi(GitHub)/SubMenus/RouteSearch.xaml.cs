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
    /// Interaction logic for RouteSearch.xaml
    /// </summary>
    public partial class RouteSearch : UserControl, ISwitchable
    {
        public RouteSearch()
        {
            InitializeComponent();
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void BackButtonPressed(object sender, RoutedEventArgs e)
        {
            //Check the needed flags in state here and jump to proper screen
            Switcher.Switch(new LaunchScreen());
        }

        private void HomeButtonPressed(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LaunchScreen());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        #endregion

    }
}