using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            movieDetails("Neighbours");
            movieDetails("Home and Away", 30);
            Console.ReadLine();
        }
        static void movieDetails(string nameOfMovie, int movieRunningTime = 90)
        {
            Console.WriteLine("The movie name is {0} and the total running time is {1}", nameOfMovie, movieRunningTime);

        }
    }
}
