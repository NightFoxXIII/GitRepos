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
using System.IO;
using System.Windows.Forms;


namespace CPSC481AirHifi_GitHub_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        internal System.Windows.Forms.ImageList ImageList1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void taxi_ads_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Canvas_MouseLeftButtonDown_Public_Transport(object sender, MouseButtonEventArgs e)
        {


            canvas1.Children.Add(weat_img2);
        }
    }
}
