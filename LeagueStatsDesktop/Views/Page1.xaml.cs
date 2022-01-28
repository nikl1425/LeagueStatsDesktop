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
using LeagueStatsDesktop.EventHelpers;
using XmlHandling;

namespace LeagueStatsDesktop.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        string fileName = "xmlDocData.xml";

        private XmlHelper xmlHelper = new XmlHelper();
        
        private readonly string _saveFilePath = LeagueStatsDesktop.DataContext.GetProjPath(true);

        public Page1()
        {
            InitializeComponent();
            xmlHelper.FileName = fileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var apiKey = "RGAPI-6b4cc2cf-580f-459d-83a0-efcd2f802b02";
        }

        private void Data_Check(object sender, RoutedEventArgs e)
        {

            bool pathExist = LeagueStatsDesktop.DataContext.FileExist(LeagueStatsDesktop.DataContext.FilesPath, "test.xml", out bool _);
            TxtMessage message = new TxtMessage("Xml Exist", pathExist.ToString());

            ConsoleOutput.Text += message.ToString();

       
            xmlHelper.CreateXmlDocument(_saveFilePath);
            
        }
    }
}
