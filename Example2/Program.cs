using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cift = 0;
            int tek = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Messages.sayi1, i);
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    cift++;
                }
                else if (sayi % 2 == 1)
                {
                    tek++;
                }

               
            }
            Console.WriteLine(Messages.cift1, cift);
            Console.WriteLine(Messages.tek1, tek);
        }
    }
    public static class Messages
    {
        public static string sayi1 = "{0}. sayiyi giriniz:";

        public static string cift1 = "çift sayi: {0}";

        public static string tek1 = "tek  sayi: {0}";

    }
}
