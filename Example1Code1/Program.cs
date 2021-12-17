using System;

namespace Example1Code1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.sicaklik);
            double sicaklik = Convert.ToDouble(Console.ReadLine());

            if (sicaklik<0)
            {
                Console.WriteLine(Messages.kati);
            }
            else if (sicaklik>0 && sicaklik<100)
            {
                Console.WriteLine(Messages.sivi);
            }
            else if (sicaklik>=100)
            {
                Console.WriteLine(Messages.gaz);
            }



        }
    }

    public static class Messages
    {
        public static string sicaklik = "Bir sıcaklık değeri giriniz";
        public static string kati = "KAtı";
        public static string sivi = "Sıvı";
        public static string gaz= "Gaz";

    }
}
