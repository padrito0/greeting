using System;

namespace Greetings 
{
    class Program 
    {

        static void Main(string[] args)
        {
            // Asking for user's name
            Console.WriteLine("What is your name?");
            
            // User inputs name
            string? name = Console.ReadLine(); 

            // Greet the user
            Console.WriteLine("Greetings " + name + ", nice to meet you!");

            // Stop program
            Console.ReadKey(); 

        }
    }
}