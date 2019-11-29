using System;
using System.Collections.Generic;




namespace MusicLibrary4_Zoli_Erik
{
    public class MovieFunctions
    {
        //change VOID
        public static string HighestBudget(Dictionary<string,Dictionary<string, string>> movies )
        {
            Dictionary<string, int> compareBudget = new Dictionary<string, int>();
            //var highestBudgetMovie = null;

            foreach (KeyValuePair<string, Dictionary<string, string>> item in movies)
            {
                string budget = item.Value["budget"];
                int realBudget = Int32.Parse(budget);
                string title = item.Key;

                compareBudget.Add(title, realBudget);
                //Compare (Dict)-compareBudget, which one has the higest budget
                //c.w. the title
            }

            int highestBudget = 0;
            string highestBudgetTitle = "";

            foreach (KeyValuePair<string, int> FinalBudget in compareBudget)
            {
                if (FinalBudget.Value > highestBudget)
                {
                    highestBudget = FinalBudget.Value;
                    highestBudgetTitle = FinalBudget.Key;
                }
                
            }
            return highestBudgetTitle;

        }

        public static string OldestMovie(Dictionary<string,Dictionary<string, string>> movies)
        {

            Dictionary<string, int> compareOldestMovie = new Dictionary<string, int>();

            foreach (KeyValuePair<string, Dictionary<string, string>> movie in movies)
            {
                string year = movie.Value["release_year"];
                int release_year = Int32.Parse(year);
                string title = movie.Key;
                compareOldestMovie.Add(title, release_year);
            }

                int oldestYear = 999999999;
                string oldestMovieTitle = "";

            foreach (KeyValuePair<string, int> final_movies in compareOldestMovie)
            {
                if (final_movies.Value < oldestYear)
                {
                    oldestYear = final_movies.Value;
                    oldestMovieTitle = final_movies.Key;
                }
            }
            return oldestMovieTitle;


        }






    }
}
