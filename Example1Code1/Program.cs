using System;

namespace Example1Code1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.heat);
            double heat = Convert.ToDouble(Console.ReadLine());

            if (heat<0)
            {
                Console.WriteLine(Messages.thick);
            }
            else if (heat>0 && heat<100)
            {
                Console.WriteLine(Messages.lıquid);
            }
            else if (heat>=100)
            {
                Console.WriteLine(Messages.gas);
            }



        }
    }

    public static class Messages
    {
        public static string heat= "Enter a temperature value";
        public static string  thick = "thick";
        public static string liquid = "liquid";
        public static string gas= "gas";

    }
}
