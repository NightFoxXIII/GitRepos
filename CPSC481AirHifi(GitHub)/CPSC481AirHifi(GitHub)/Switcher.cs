using System.Windows.Controls;

namespace CPSC481AirHifi_GitHub_
{
  	public static class Switcher
  	{
        public static MainWindow window;

    	public static void Switch(UserControl newPage)
    	{
            window.Navigate(newPage);
    	}

    	public static void Switch(UserControl newPage, Session state)
    	{
            window.Navigate(newPage, state);
    	}
  	}
}
