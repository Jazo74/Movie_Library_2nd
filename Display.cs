using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    public class Display
    {
        public void PrintProgramMenu(List<String> menu_commmands, string title)
        {
            Console.WriteLine(title);
            menu_commmands.ForEach(Console.WriteLine);
        }

          public static void Header(string title)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));

        }


    }
}
