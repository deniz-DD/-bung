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
using System.Data;

namespace Übung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int input_storage = 1;
        private List<string> numbers = new List<string>();
        

        public MainWindow()
        {
            InitializeComponent();
        }
       private  void AddText(string value)
        {
            txt_down.Text += value;
        }

        private void btn0_Click(object sender, RoutedEventArgs e) => AddText("0");
        private void btn1_Click(object sender, RoutedEventArgs e) => AddText("1");
        private void btn2_Click(object sender, RoutedEventArgs e) => AddText("2");
        private void btn3_Click(object sender, RoutedEventArgs e) => AddText("3");
        private void btn4_Click(object sender, RoutedEventArgs e) => AddText("4");
        private void btn5_Click(object sender, RoutedEventArgs e) => AddText("5");
        private void btn6_Click(object sender, RoutedEventArgs e) => AddText("6");
        private void btn7_Click(object sender, RoutedEventArgs e) => AddText("7");
        private void btn8_Click(object sender, RoutedEventArgs e) => AddText("8");
        private void btn9_Click(object sender, RoutedEventArgs e) => AddText("9");


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }



        private void btnPlus_Click(object sender, RoutedEventArgs e) => AddText("+");
        private void btnMinus_Click(object sender, RoutedEventArgs e) => AddText("-");
        private void btnMutli_Click(object sender, RoutedEventArgs e) => AddText("*");
        private void btnDiv_Click(object sender, RoutedEventArgs e) => AddText("/");













        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            txt_down.Text = "";
            try
            {
                string expr = txt_down.Text;
                var result = new DataTable().Compute(expr, null);
                txt_down.Text = result.ToString();
            }
            catch
            {
                txt_down.Text = "Fehler";
            }
        }

      
    }
}