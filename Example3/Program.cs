using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.number1);
            int number = Convert.ToInt32(Console.ReadLine());

            bool singlecouple = Control(number);

            if (singlecouple==true)
            {
                Console.WriteLine(Messages.couple);
            }
            else
            {
                Console.WriteLine(Messages.single);
            }

            //Console.WriteLine(Control(number));

        }

          static bool Control(int number)
        {
            if (number%2==0)
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
        public static string number1 = "Enter a number";
        public static string couple = "Number is Even";
        public static string single= "Number is odd";


    }
    
}
