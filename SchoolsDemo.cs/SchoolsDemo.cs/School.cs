using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo.cs
{
    class School : IComparable 
    {
        String schoolName;
        int numberOfStudents;

        public String SchoolName
        {
            get
            {
                return schoolName;
            }
            set
            {
                schoolName = value;
            }

        }
        public int NumberOfStudents
        {
            get
            {
                return numberOfStudents;
            }
            set
            {
                numberOfStudents = value;
            }
        }
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            School temp =(School )o;
            if (this.numberOfStudents > temp.numberOfStudents)
                returnVal = 1;
            else
                if (this.numberOfStudents < temp.numberOfStudents)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal ;
        }

        static void Main(string[] args)
        {
            School [] schools = new School[5];
            for (int x = 0; x < schools.Length; ++x)
            {
                schools[x] = new School() ;
                Console.Write("Enter the school name>> ");
                schools[x].SchoolName = Console.ReadLine();
                Console.Write("Enter the number of Sudents enrolled>> ");
                schools[x].NumberOfStudents = Convert .ToInt32 (Console.ReadLine());
            }
            
            Array.Sort(schools);
            Console.WriteLine();
            Console.WriteLine("Schools arranged by order of enrollment");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            for (int y = 0; y < schools.Length; ++y)
            {
                Console.WriteLine("School " + (y + 1) + " is called {0}", schools[y].SchoolName);
                Console.WriteLine("Number of students enrolled in school " + (y + 1) + " is {0}", schools[y].NumberOfStudents);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
