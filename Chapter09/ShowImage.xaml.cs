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
    /// Interaction logic for ShowImage.xaml
    /// </summary>
    public partial class ShowImage : Window
    {
        private List<Person> people = new List<Person>();
        FileManagement file = new FileManagement("C:\\Users\\acer\\Desktop\\CE216\\Chapter09\\details.txt");
        private string imageFile = "image/";
        private int index = 0;
        public ShowImage()
        {
            InitializeComponent();
            people = new List<Person>();
            foreach (string i in file.ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[4];
                    data = i.Split(',');
                    string fullname = data[0];
                    string telNo = data[1];
                    string bd = data[2];
                    string image = data[3];
                    Person p = new Person(fullname, telNo, bd);
                    p.Image = imageFile + image + ".png";
                    people.Add(p);
                }
            }
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(people[index].Image, UriKind.Relative);
            bitmap.EndInit();
            ImageShow.Source = bitmap;
            textDisplay.Text = "Name: " + people[index].FullName + "\nTel No: "
                + people[index].TelNo + "\nBirthday: " + people[index].DateOfBirth
                + "\nAge: " + people[index].Age;
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            if (index >= people.Count - 1)
            {
                index = 0;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(people[index].Image, UriKind.Relative);
                bitmap.EndInit();
                ImageShow.Source = bitmap;
                textDisplay.Text = "Name: " + people[index].FullName + "\nTel No: "
                    + people[index].TelNo + "\nBirthday: " + people[index].DateOfBirth
                    + "\nAge: " + people[index].Age;
            }
            else
            {
                index++;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(people[index].Image, UriKind.Relative);
                bitmap.EndInit();
                ImageShow.Source = bitmap;
                textDisplay.Text = "Name: " + people[index].FullName + "\nTel No: "
                    + people[index].TelNo + "\nBirthday: " + people[index].DateOfBirth
                    + "\nAge: " + people[index].Age;
            }
        }
    }
}
