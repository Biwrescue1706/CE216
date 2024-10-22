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
using System.Windows.Shapes;

namespace Chapter09
{
    /// <summary>
    /// Interaction logic for Subtract.xaml
    /// </summary>
    public partial class Subtract : Window
    {
        public Subtract()
        {
            InitializeComponent();
        }
        private void Calulate_Click(object sender, RoutedEventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.TextBox1.Text = this.TextBox1.Text;
            calculator.TextBox2.Text = this.TextBox2.Text;
            calculator.TextBox4.Text = this.TextBox4.Text;
            calculator.TextBox5.Text = this.TextBox5.Text;
            calculator.TextBox7.Text = this.TextBox7.Text;
            calculator.TextBox8.Text = this.TextBox8.Text;

            calculator.TextBox3.Text = Addition(this.TextBox1.Text, this.TextBox2.Text);
            calculator.TextBox6.Text = Addition(this.TextBox4.Text, this.TextBox5.Text);
            calculator.TextBox9.Text = Addition(this.TextBox7.Text, this.TextBox8.Text);

            calculator.Show();
            this.Close();
        }

        private string Addition(string val1, string val2)
        {
            return (Convert.ToInt32(val1) + Convert.ToInt32(val2)).ToString();
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.Text = Subtraction(TextBox1.Text, TextBox2.Text);
            TextBox6.Text = Subtraction(TextBox4.Text, TextBox5.Text);
            TextBox9.Text = Subtraction(TextBox7.Text, TextBox8.Text);
        }

        private string Subtraction(string val1, string val2)
        {
            return (Convert.ToInt32(val1) - Convert.ToInt32(val2)).ToString();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
            TextBox4.Text = "0";
            TextBox5.Text = "0";
            TextBox6.Text = "0";
            TextBox7.Text = "0";
            TextBox8.Text = "0";
            TextBox9.Text = "0";
        }

        private void Close_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
