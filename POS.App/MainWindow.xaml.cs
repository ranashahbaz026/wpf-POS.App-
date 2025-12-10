using POS.App.Views.RibbonViews;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace POS.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            RibbonTabs.SelectedIndex = 0;
            RibbonContent.Content = new HomeRibbon();
        }

        private void RibbonTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RibbonTabs.SelectedItem is TabItem tab)
            {
                switch (tab.Header.ToString())
                {
                    case "Home":
                        RibbonContent.Content = new HomeRibbon();
                        break;

                    case "Reports":
                        RibbonContent.Content = new ReportsRibbon();
                        break;

                    case "Settings":
                        RibbonContent.Content =
                            new TextBlock { Text = "Settings Section", Margin = new Thickness(20) };
                        break;
                }
            }
        }
    }
}