using POS.App.Views.Products.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS.App.Views.RibbonViews
{
    /// <summary>
    /// Interaction logic for HomeRibbon.xaml
    /// </summary>
    public partial class HomeRibbon : UserControl
    {
        public HomeRibbon()
        {
            InitializeComponent();
        }

        private void OpenProductsTab(object sender, RoutedEventArgs e)
        {
            var main = (MainWindow)Application.Current.MainWindow;
            main.OpenWorkspaceTab("Products", new CategoryListView());
        }

        private void OpenUsersTab(object sender, RoutedEventArgs e)
        {
            var main = (MainWindow)Application.Current.MainWindow;
            main.OpenWorkspaceTab("Users", new CategoryListView());
        }
    }
}
