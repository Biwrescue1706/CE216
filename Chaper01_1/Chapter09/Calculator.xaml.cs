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
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calulate_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.Text = Addition(TextBox1.Text, TextBox2.Text);
            TextBox6.Text = Addition(TextBox4.Text, TextBox5.Text);
            TextBox9.Text = Addition(TextBox7.Text, TextBox8.Text);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
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
        private string Addition(string val1, string val2)
        {
            return (Convert.ToInt32(val1) + Convert.ToInt32(val2)).ToString();
        }
        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            Subtract subtract = new Subtract();
            subtract.TextBox1.Text = this.TextBox1.Text;
            subtract.TextBox2.Text = this.TextBox2.Text;
            subtract.TextBox4.Text = this.TextBox4.Text;
            subtract.TextBox5.Text = this.TextBox5.Text;
            subtract.TextBox7.Text = this.TextBox7.Text;
            subtract.TextBox8.Text = this.TextBox8.Text;

            subtract.TextBox3.Text = Subtract(this.TextBox1.Text, this.TextBox2.Text);
            subtract.TextBox6.Text = Subtract(this.TextBox4.Text, this.TextBox5.Text);
            subtract.TextBox9.Text = Subtract(this.TextBox7.Text, this.TextBox8.Text);

            subtract.Show();
            this.Close();
        }
        private string Subtract(string val1, string val2)
        {
            return (Convert.ToInt32(val1) - Convert.ToInt32(val2)).ToString();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
