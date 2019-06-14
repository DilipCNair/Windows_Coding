using System.Windows;
using System.Windows.Controls;

namespace ViewNavigationAndHierarchy.Views
{
    /// <summary>
    /// Interaction logic for CustomerListView.xaml
    /// </summary>
    public partial class CustomerListView : UserControl
    {
        public static string message { get; set; }
        public static int Count {get;set;}
        public CustomerListView()
        {
            InitializeComponent();
            message = "Hey"; 
        }

        private void button_Clicked(object sender, RoutedEventArgs e)
        {
            Count++;
            message = "Count = " + Count;
            MessageBox.Show(message);
        }

        private void Button2_Clicked(object sender, RoutedEventArgs e)
        {
            Count = 0;
            message = "Count = ";
        }
    }
}
