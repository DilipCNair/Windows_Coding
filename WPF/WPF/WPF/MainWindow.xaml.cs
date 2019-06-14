using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Pressed(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FullScreen_Pressed(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.None;
            //this.AllowsTransparency = true;


        }

        private void Normal_Pressed(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.SingleBorderWindow;
            //this.AllowsTransparency = false;
        }
    }
}
