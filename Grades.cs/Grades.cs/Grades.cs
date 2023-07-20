using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grades.cs
{
    class Grades
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Random rand = new Random ((int)now.Millisecond );

            int[,] Grades = new int[5, 10];
            for (int x = 0; x < Grades.GetLength(0); ++x)
            {
                for (int y = 0; y < Grades.GetLength(1); ++y)
                {

                    Grades[x, y] = 70 + rand.Next() % 31;
                }
                
            }
            int[] Average = new int[10];
            Console.WriteLine("Grade summary:\r\n");
            Console.WriteLine("Student  1   2   3   4   5   6   7   8   9   10");
            Console.WriteLine("        --------------------------------------");

            for (int x = 0; x < Grades.GetLength(0); ++x)
            {
                Console.Write("Test " + (x + 1) + " ");
                for (int y = 0; y < Grades.GetLength(1); ++y)
                {
                    Average[y] += Grades[x, y];
                    Console.Write("{0,4:D}", Grades[x, y]);
                }
                Console.WriteLine();

            }
            Console.Write("\r\n Avg. ");
            foreach (int AVg in Average)
            {
                Console.Write("{0,4:D}", AVg / Grades.GetLength(0));
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
