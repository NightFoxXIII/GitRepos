﻿using System;
using System.Collections.Generic;
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

namespace JagoanFisika
{
	/// <summary>
	/// Interaction logic for Login.xaml
	/// </summary>
	public partial class Login : UserControl
	{
		public Login()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch(new MainMenu());
		}
	}
}