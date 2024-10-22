using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter04_01
{
    class Program1
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Customer[] listOfCustomer = new Customer[3];
            Video[] listOfVideo = new Video[4];
            Rent[] listOfRent = new Rent[3];

            for (int i = 0; i < listOfCustomer.Length; i++)
            {
                Console.WriteLine("================================================");
                Console.Write($"Pleae Enter You Name #{i+1} : ");
                string name = Console.ReadLine();
                Console.Write($"Pleae Enter You SurName #{i + 1} : ");
                string surName = Console.ReadLine();
                listOfCustomer[i] = new Customer(Convert.ToString(ran.Next(0,999999)),name,surName,"Standard" );
            }
                Console.WriteLine("================================================");

            for (int i = 0;i < listOfVideo.Length;i++) 
            {
                Console.Write($"Pleae Enter a Video Name #{i + 1} : ");
                string videoName = Console.ReadLine();
                listOfVideo[i] = new Video(Convert.ToString(ran.Next(0, 999999)), videoName);
            }

            for (int i = 0; i < listOfRent.Length; i++)
            {
                DateTime datenow = DateTime.Now;
                listOfRent[i] = new Rent(datenow.ToString("dd/MM/yyyy"), listOfCustomer[ran.Next(listOfCustomer.Count())].GetId(),listOfVideo[ran.Next(listOfVideo.Count())].GetVideoId());
            } 

                Console.WriteLine("======================Result======================");
            for(int i = 0; i < listOfRent.Length; i++)
            {
                Console.WriteLine($"Date : {listOfRent[i].GetRentDate()}");
                for (int j = 0; j< listOfCustomer.Length; j++)
                {
                    if (listOfRent[i].GetCustomerId() == listOfCustomer[j].GetId())
                    {
                        Console.WriteLine($"Customer Name : {listOfCustomer[j].GetFullName( )}");
                    }
                }
                for ( int j = 0;j< listOfVideo.Length; j++)
                {
                    if (listOfRent[i].GetVideoId() == listOfVideo[j].GetVideoId())
                    {
                        Console.WriteLine($"Video Name : {listOfVideo[j].GetVideoName()}");
                    }
                }
            }
        }
    }
}
