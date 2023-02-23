using System;

namespace HelloWorld_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Asks the user for their name.
            Console.WriteLine("Hello new user! Please type your first and last name below.");

            // String that the user can use for their first name.
            string firstName = Console.ReadLine();

            // String that the user can use for their last name.
            string lastName = Console.ReadLine();

            // Thanks the user and welcomes them to the program.
            Console.WriteLine($"Thank you {firstName} {lastName}! Welcome to our wonderful program.");
        }
    }
}
