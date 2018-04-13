using System;

namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetFunction();
            LanguageReview();
        }

        /// <summary>
        /// This function is used for welcoming the application user
        /// </summary>
        private static void GreetFunction()
        {
            Console.Write("Please enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(String.Format("Hello {0}. Welcome to visual studio.", firstName ));            
        }

        /// <summary>
        /// To get user's language review
        /// </summary>
        private static void LanguageReview()
        {
            Console.WriteLine("Do you like C# ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "yes":
                case "maybe":
                    Console.WriteLine("Great!");
                    break;
                case "no":
                    Console.WriteLine("Too bad!");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

