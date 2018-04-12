using System;

namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetFunction();
        }

        /// <summary>
        /// This function is used for welcoming the application user
        /// </summary>
        private static void GreetFunction()
        {
            Console.WriteLine("Please enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(String.Format("Hello {0}. Welcome to visual studio.", firstName ));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
