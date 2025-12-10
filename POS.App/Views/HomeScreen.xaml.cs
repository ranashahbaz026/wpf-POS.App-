using System.Windows;
using System.Windows.Controls;

namespace POS.App.Views
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to categories screen
            //((MainWindow)Application.Current.MainWindow).NavigateToCategories(sender, e);
        }
    }
}
