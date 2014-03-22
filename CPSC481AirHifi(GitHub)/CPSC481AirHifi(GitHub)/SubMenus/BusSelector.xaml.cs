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
    public partial class BusSelector : UserControl
    {
        public BusSelector()
        {
            InitializeComponent();
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void BackButtonPress(object sender, RoutedEventArgs e)
        {
            //Set the needed flags in state here
            Switcher.Switch(new LaunchScreen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LaunchScreen());
        }
        #endregion

    }
}

