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

namespace Übung
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
        static int input_storage = 1;
        string[] numbers = new string[input_storage];

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txt_down.Text += "1";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txt_down.Text += "2";
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txt_down.Text += "3";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn7_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}