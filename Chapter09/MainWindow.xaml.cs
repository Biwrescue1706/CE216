using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter09
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
        private void Display_Click(object sender, RoutedEventArgs e)
        {
            if (Hello.IsChecked == true)
            {
                MessageBox.Show("Hello", "Select", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else if (Bye.IsChecked == true)
            {
                MessageBox.Show("Bye Bye");
            }
            else
            {
                MessageBox.Show("Please Select Option Message");
            }
        }
    }
}