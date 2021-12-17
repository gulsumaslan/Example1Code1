using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diziler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i <diziler.Length; i++)
            {
                if (diziler[i]%2==0)
                {
                    Console.WriteLine(diziler[i]);
                }
            }
           
        }

        static void deneme(int[] diziler)
        {
            foreach (var dizi in diziler)
            {
                Console.WriteLine(dizi);
            }
        }
    }
}
