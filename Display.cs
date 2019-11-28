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

        public void Header(string title)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("-----{0}----", title);
            Console.WriteLine("-------------");

        }



    }
}