using System;
using System.IO;

namespace MovieLibrary
{
    public class UserInterface
    {
        public static string userInput(string message)
        {
            System.Console.WriteLine(message);
            string userinput = Console.ReadLine();

            return userinput;

        }
    }
}