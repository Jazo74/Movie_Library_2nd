using System;
using System.Collections.Generic;
// RESTORE
namespace MovieLibrary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Dictionary<String, Dictionary<String, String>> dataBase = new Dictionary<String, Dictionary<String, String>>();
            
            dataBase = FileHandler.DictFromFile("movies.ini");
            
            Console.WriteLine(dataBase.Count);
            
            foreach (string record in dataBase.Keys)
            {
     
                Console.WriteLine("Title: {0}", record);
                Console.WriteLine("Director: {0}", dataBase[record]["director"]);
                Console.WriteLine("Year: {0}", dataBase[record]["year"]);
                Console.WriteLine("Stars: {0}", dataBase[record]["stars"]);
                Console.WriteLine("budget: {0}", dataBase[record]["budget"]);

            }
            
            System.Console.ReadKey();

            /*int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader("movies.ini");

            while((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;

            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.ReadLine();
            */



        }
    }
}
