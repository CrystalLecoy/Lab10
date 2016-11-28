using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!" + Environment.NewLine);
            //Console.WriteLine(Environment.NewLine);
            Console.WriteLine("There are 100 movies in this list." + Environment.NewLine);

            bool again = true;
            do
            {
                Console.WriteLine("What category are you interested in? (animated, drama, horror, or scifi)");
                //Console.WriteLine("The catagories are: animated, drama, horror, and scifi." + Environment.NewLine);
                string userInput = Console.ReadLine();

                List<Movie> MovieList = new List<Movie>();
                MovieList = MovieIO.MovieCatalog;

                //MovieList = MovieList.Where(mbox => mbox.Title == userInput).OrderBy (mbox => mbox.Title).ToList();

                int i = 0;
                foreach (Movie movie in MovieList)
                    if (movie.Category == userInput)
                    {
                        i++;
                        Console.WriteLine(movie.Title);
                        if (i >= 10) break;
                    }


                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Would you like to continue? (Yes or No)");
                string answer = Console.ReadLine();
                again = answer.ToLower() == "yes" || answer.ToLower() == "y";
            }
            while (again);

            do
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
            while (!again);
        }
    }
}
        
  
