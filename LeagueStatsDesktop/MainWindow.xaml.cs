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
using LeagueStatsDesktop.Views;


namespace LeagueStatsDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Page> pages = new List<Page>();
        private List<string> views = new List<string>() { "Page1", "Page2", "Page3" };

        // Get all out views
        Page page1 = new Page1();
        Page page2 = new Page2();
        Page page3 = new Page3();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pages.AddRange(new List<Page>()
            {
                page1, page2, page3
            });

            Dictionary<string, Page> pageKeyValueMapping = new Dictionary<string, Page>();

            for (int i= 0; i < views.Count; i++)
            {
                pageKeyValueMapping.Add(views[i], pages[i]);
            }

            var navBar = new navigation();
            navBar.Pages = pages;
            navBar.Views = views;
            navBar.PagesDict = pageKeyValueMapping;

            double sizeContainer = NavBarContent.ActualWidth;

            var btnList = navBar.GenerateNavButtons(sizeContainer);

            foreach (var btn in btnList)
            {
                NavBarContent.Children.Add(btn);
            }

            

        }

        
           

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            MainContent.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
    }
}
