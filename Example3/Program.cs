using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.sayi1);
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool tekcift = Kontrol(sayi);

            if (tekcift==true)
            {
                Console.WriteLine(Messages.cift);
            }
            else
            {
                Console.WriteLine(Messages.tek);
            }

            //Console.WriteLine(Kontrol(sayi));

        }

          static bool Kontrol(int sayi)
        {
            if (sayi%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class Messages
    {
        public static string sayi1 = "Bir sayi giriniz";
        public static string cift = "Sayi Çifttir";
        public static string tek = "Sayi Tektir";


    }
    
}
