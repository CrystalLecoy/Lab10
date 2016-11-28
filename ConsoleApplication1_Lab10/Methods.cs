using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab10
{
    static public class Methods
    {
        //static public void displayAppWelcome()
        //{
        //    Console.WriteLine("Welcome to the Movie List Application!");
        //    Console.WriteLine();
        //    Console.WriteLine("There are 100 movies in this list.");
        //}
        //static public string getUserInput()
        //{
        //    Console.Write("What category are you interested in?");
        //    return Console.ReadLine();
        //}
        //static public void WriteCategories(List<string> CatagoryList)
        //{
        //    string text = string.Join(", ", CatagoryList);
        //    Console.WriteLine($"The categories are {text}");
        //}
        static public void WriteCategoriesWithNumbers(List<string> CategoryList)
        {
            string text = "";

            for (int i = 0; i < CategoryList.Count; i++)
            {
                if (i > 0) { text += ";"; }
                text += $"{i}-{CategoryList[i]}";
            }
            Console.WriteLine($"The categories are {text}");
        }


        static public void displayMovieList(List<Movie> movies)
        {
            if (movies == null || movies.Count == 0)
            {
                Console.WriteLine("NO SUCH MOVIE");
            }
            else
            {
                foreach (Movie movie in movies)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
        //static public void displayCatalogList()
        //{
        //    Console.WriteLine($"There are {MovieMagic.MovieCatalog.Count()} movies in this list.");
        //}

        //static public bool askContinue()
        //{
        //    Console.Write("Continue? (y/n):");
        //    string text = Console.ReadLine();
        //    return TextValidator.isValidY(text);
        //}


        static public void GoodByeText()
        {
            // Console.WriteLine($"Goodbye. You created {Circle.getObjectCount()} Circle object(s)."); 
        }

    }
}
