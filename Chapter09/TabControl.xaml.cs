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
    /// Interaction logic for TabControl.xaml
    /// </summary>
    public partial class TabControl : Window
    {
        private string dateOfBirth;
        private int dateSelect;
        private string monthSelect;
        private int yearSelect;
        private string name;
        private string telNo;
        private List<Person> people;

        FileManagement file = new FileManagement("C:\\Users\\acer\\Desktop\\CE216\\Chapter09\\person.txt");
        private List<string> texts = new List<string>();

        public TabControl()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                dateSel.Items.Add(i);
            }

            monthSel.Items.Add("January");
            monthSel.Items.Add("Febuary");
            monthSel.Items.Add("March");
            monthSel.Items.Add("April");
            monthSel.Items.Add("May");
            monthSel.Items.Add("June");
            monthSel.Items.Add("July");
            monthSel.Items.Add("August");
            monthSel.Items.Add("September");
            monthSel.Items.Add("October");
            monthSel.Items.Add("November");
            monthSel.Items.Add("December");

            int y = DateTime.Today.Year;
            int z = y - 100;
            for (int i = y; i >= z; i--)
            {
                yearSel.Items.Add(i);
            }
            people = new List<Person>();
            foreach (string i in file.ReadFile())
            {
                if (i != "")
                {
                    texts.Add(i);
                    string[] data = new string[3];
                    data = i.Split(',');
                    string fullname = data[0];
                    string telNo = data[1];
                    string bd = data[2];
                    Person p = new Person(fullname, telNo, bd);
                    people.Add(p);
                }
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            name = textName.Text;
            telNo = textTelNo.Text;
            dateOfBirth = dateSelect + "/" + monthSelect + "/" + yearSelect;
            string show = "Full Name: " + name + "\nTelepnone No.: " + telNo + "\nDate Of Birth: " + dateOfBirth;
            MessageBox.Show(show, "Confirm");
            textName.Text = "";
            textTelNo.Text = "";
            Person person = new Person(name, telNo, dateOfBirth);
            string text = person.SetData();
            texts.Add(text);
            file.WriteFile(texts);
        }

        private void monthSel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            monthSelect = monthSel.SelectedItem.ToString();
        }

        private void yearSel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            yearSelect = Int32.Parse(yearSel.SelectedItem.ToString());
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            people = new List<Person>();
            foreach (string i in file.ReadFile())
            {
                if (i != "")
                {
                    texts.Add(i);
                    string[] data = new string[3];
                    data = i.Split(',');
                    string fullname = data[0];
                    string telNo = data[1];
                    string bd = data[2];
                    Person p = new Person(fullname, telNo, bd);
                    people.Add(p);
                }
            }
            displayData.ItemsSource = people;
        }

        private void dateSel_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            dateSelect = Int32.Parse(dateSel.SelectedItem.ToString());
        }
    }
}
