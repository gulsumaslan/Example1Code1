using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.Name);
            string name = Console.ReadLine();

            Console.WriteLine(Messages.SurName);
            string LastName = Console.ReadLine();


            Console.WriteLine(Messages.screen, name, LastName);


        }
    }
    public static class Messages
    {
        public static string Name= "enter your name";
        public static string SurName = "Enter your last name";
        public static string screen = "hello {0},{1}:";



    }
}
