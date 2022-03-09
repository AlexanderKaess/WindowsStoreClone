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
using WindowsStoreClone.Pages;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainPage MainWindowContentPage;

        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new MainPage();

            //Here is a additional comment
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
            //added a few more lines or something else
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MainWindowContentPage;
        }
    }
}
