using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] series= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i <series.Length; i++)
            {
                if (series[i]%2==0)
                {
                    Console.WriteLine(series[i]);
                }
            }
           
        }

        static void example(int[] series)
        {
            foreach (var soap in series)
            {
                Console.WriteLine(soap);
            }
        }
    }
}
