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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FeaturedAppsViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = (UIElement)sender;
            element.Opacity = 0;

            //set the animation of opacity from white to no opacity within 10 seconds
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 5))
            };

            //begin the animation, Opacity.Property is the property (target) which we want to change and with the animation we want
            element.BeginAnimation(UIElement.OpacityProperty, animation);
        }
    }
}
