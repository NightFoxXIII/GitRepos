﻿using System;
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
    /// Interaction logic for HotelReview.xaml
    /// </summary>
    public partial class HotelReview : UserControl, ISwitchable
    {
        private Session session;
        private TextBox hotelreviewsbox;
        private TextBox hotelreviewtextbox;
        private int i = 0;
        private int c = 2;

        public HotelReview()
        {
            InitializeComponent();
            TaxiAdvert.Child = new CabAdvert1();
            DispatcherTimer dispatchertimer = new DispatcherTimer();

            dispatchertimer.Tick += new EventHandler(dispatchertimer_Tick);
            dispatchertimer.Interval = new TimeSpan(0, 0, 2);
            dispatchertimer.Start();
        }

        #region Image Timer Stuff

        private void dispatchertimer_Tick(object sender, EventArgs e)
        {
            if (i >= 3)
            {
                i = 0;
                c++;
                if (c >= 4)
                    c = 1;
            }

            i++;

            switch (c)
            {
                case 1:
                    TaxiAdvert.Child = new CabAdvert1();
                    break;
                case 2:
                    TaxiAdvert.Child = new CabAdvert2();
                    break;
                case 3:
                    TaxiAdvert.Child = new CabAdvert3();
                    break;
            }
        }
        #endregion

        #region Click Events
        private void AddReview(object sender, RoutedEventArgs e)
        {
            session.addHotelReview(hotelreviewtextbox.Text);
            hotelreviewtextbox.Text = "";
            hotelreviewsbox.Text = session.getHotelReviews();
        }

        private void ClearTextBox(object sender, RoutedEventArgs e)
        {
            var box = sender as TextBox;
            box.Text = "";
        }
        #endregion

        #region Keyboard Events
        public void EnterKeyPressed(object sender, KeyEventArgs e)
        {
            var box = sender as TextBox;
            if (e.Key == Key.Enter)
            {
                session.addHotelReview(hotelreviewtextbox.Text);
                hotelreviewtextbox.Text = "";
                hotelreviewsbox.Text = session.getHotelReviews();
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

        private void HotelName(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = "Reviews: " + session.gethotel();
        }

        private void HotelReviews(object sender, RoutedEventArgs e)
        {
            var box = sender as TextBox;
            hotelreviewsbox = box;
            box.Text = session.getHotelReviews();
        }

        private void ReviewBox(object sender, RoutedEventArgs e)
        {
            var box = sender as TextBox;
            hotelreviewtextbox = box;
        }
        #endregion

        #region Window Transitions
        private void BackButtonPress(object sender, RoutedEventArgs e)
        {
            var back = new Back();
            back.StepBack(session);
        }

        private void BusSelectionChanged(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new BusSelector(), session);
        }

        private void FoodSearch(object sender, RoutedEventArgs e)
        {
            session.poppreviousscreen();
            Switcher.Switch(new FoodSelector(), session);
        }

        private void EventSearch(object sender, RoutedEventArgs e)
        {
            session.poppreviousscreen();
            Switcher.Switch(new EventSelector(), session);
        }

        private void DirectionsSearch(object sender, RoutedEventArgs e)
        {
            session.setpreviousscreen("hotelreviewsscreen");
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