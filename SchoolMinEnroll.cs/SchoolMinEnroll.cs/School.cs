using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolMinEnroll.cs
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
            Console.Write("Enter a minimum enrollment figure >>");
            int minimumEnrollmentFigure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("School Objects greater than or equal to minimum enrollment figure of {0}", minimumEnrollmentFigure);
            Console.WriteLine("************************************************************************");
            for (int i = 0; i < schools.Length; ++i)
            {
                if ((schools[i].NumberOfStudents == minimumEnrollmentFigure) || (schools [i].NumberOfStudents > minimumEnrollmentFigure ))
                {
                    Console.WriteLine("School " + (i + 1) + " is called {0}", schools[i].SchoolName);
                    Console.WriteLine("Number of students enrolled in school " + (i + 1) + " is {0}", schools[i].NumberOfStudents);
                    
                }
                else 
                {
                    Console.WriteLine("School object " + (i+1) + " does not fulfill the criteria");
                    //Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}

