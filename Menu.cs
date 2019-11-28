using System;
namespace MovieLibrary
{
    public class Menu
    {
        public static void ShowMenu(string init)
        {
            Console.Clear();
            switch (init)
            {
                case "main_menu": // Main menu case

                    string[] mainMenu = new string[5] { "Albums by genre", "The longest album", "The lenght of all albums", "Delete album", "exit program" };
                    int count = 1;
                    foreach (string option in mainMenu)
                    {
                        Console.WriteLine("(" + count + ".) " + option);
                        count++;
                    }
                    break;
                case "sub_menu":
                    break;
                default:
                    break;
            }
        }


        public static Boolean Choose()
        {
            Console.Write("Choose an option (1-5): ");
            ConsoleKeyInfo choice = Console.ReadKey();
            Console.Clear();
            
            switch (choice.Key)
            {
                case ConsoleKey.D1 :
                    Console.WriteLine("1. opcio");
                    break;
                case ConsoleKey.D2 :
                    Console.WriteLine("2. opcio");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("3. opcio");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("4. opcio");
                    break;
                case ConsoleKey.D5:
                    Environment.Exit(-1);
                    break;
                default:
                    return false;
                    break;
            }
            Console.WriteLine("Meg nincs vege");
        }
    }
}
