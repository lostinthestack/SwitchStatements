using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?    ");

            var userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "gym":
                    Console.WriteLine("Ok, jock! Take my lunch money and go!");
                    break;
                case "science":
                    Console.WriteLine("Look out for the jock; he was looking for you and seemed hungry.");
                    break;
                case "Math":
                    Console.WriteLine("At least you won't be flipping burgers.");
                    break;
                case "history":
                    Console.WriteLine("Hey, the President's on the phone for you!");
                    break;
                case "English":
                    Console.WriteLine("I already speak English, do I really have to take this course?");
                    break;
                default:
                    Console.WriteLine("Go back to school, dummy!");
                    break;
            }
        }
    }
}
