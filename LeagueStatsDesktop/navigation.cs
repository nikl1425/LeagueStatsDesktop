using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LeagueStatsDesktop
{
    public partial class navigation : Window
    {
        private List<string> views = new List<string>();

        public List<string> Views
        {
            get { return views; }
            set { views = value; }
        }

        private List<Page> pages = new List<Page>();

        public List<Page> Pages
        {
            set { pages = value; }
            get { return pages; }
        }

        private Dictionary<string, Page> pagesDict = new Dictionary<string, Page>();

        public Dictionary<string, Page> PagesDict
        {
            set { pagesDict = value; }
            get { return pagesDict; }
        }


        public List<Button> GenerateNavButtons(double containerSize = 0)
        {
            var btnList = new List<Button>();

            foreach (var view in Views)
            {
                var button = new Button();

                int viewsCount = views.Count;
             
                button.Background = Brushes.LightGray;
                button.Content = view;
                button.Click += new RoutedEventHandler(btnClickEvent);

                if (containerSize > 0)
                {
                    button.Width = containerSize / viewsCount;
                }

                btnList.Add(button);
            }

            return btnList;
        }

        private void btnClickEvent(object sender, RoutedEventArgs e)
        {
            MainWindow mn = (MainWindow)Application.Current.MainWindow;
            var props = sender as Button;

            var pageName = string.IsNullOrEmpty(props.Content.ToString()) ? views[0] : props.Content.ToString();



            Page redirectPage = pagesDict[pageName];

            if(props != null)
            {
                mn.MainContent.Content = redirectPage;
            }
        }


        public List<string> GetViews()
        {
            return views;
        }
    }
}
