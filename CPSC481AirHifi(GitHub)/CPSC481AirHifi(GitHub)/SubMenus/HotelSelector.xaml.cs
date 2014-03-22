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
    /// Interaction logic for HotelSelector.xaml
    /// </summary>
    public partial class HotelSelector : UserControl, ISwitchable
    {
        private Session session;

        public HotelSelector()
        {
            InitializeComponent();
        }

        #region Mouseover Events

        #endregion

        #region Window Transitions

        #endregion

        #region ISwitchable Members
        public void UtilizeState(Session state)
        {
            session = state;
        }
        #endregion
    }
}
