using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int couple = 0;
            int only = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Messages.number1, i);
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    couple++;
                }
                else if (number % 2 == 1)
                {
                    only++;
                }

               
            }
            Console.WriteLine(Messages.couple1, couple);
            Console.WriteLine(Messages.only1, only);
        }
    }
    public static class Messages
    {
        public static string number1 = "{0}. enter number:";

        public static string couple1 = "couple: {0}";

        public static string only1 = "only: {0}";

    }
}
