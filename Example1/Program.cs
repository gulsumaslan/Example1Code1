using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.Ad);
            string name = Console.ReadLine();

            Console.WriteLine(Messages.Soyad);
            string LastName = Console.ReadLine();


            Console.WriteLine(Messages.ekran, name, LastName);


        }
    }
    public static class Messages
    {
        public static string Ad = "Adınızı giriniz";
        public static string Soyad = "Soyadınızı giriniz";
        public static string ekran = "Merhaba {0},{1}:";



    }
}
