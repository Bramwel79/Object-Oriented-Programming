using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student.cs
{
    class Student : IComparable 
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName ;
            }
            set
            {
                lastName =value;
            }
        }
        /* alternatively use the shorcut since there is no additional
         * code
         * public int IdNumber{get;set}
         * public string LastName{get;set}*/
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }

        internal static void Display(Student stu)
        {
           Console.WriteLine ("{0,5} {1,-10} {2,6}",
               stu.IdNumber ,stu.LastName ,
               stu.GradePointAverage .ToString ("F1"));
        }
        static void Main(string[] args)
        {
            Student[] student = new Student[8];
            int x;
            int id;
            string name;
            double gpa;
            for (x = 0; x < student.Length; ++x)
            {
                GetData(out id, out name, out gpa);
                student[x] = new Student(id, name, gpa);
            }
            Array.Sort(student);
            Console.WriteLine("Sorted List:");
            for (x = 0; x < student.Length; ++x)
            {
                Display(student[x]);
            }
            Console.ReadLine();

        }
        internal static void GetData(out int id, out string name,
out double gpa)
        {
            string inString;
            Console.Write("Please enter student ID number ");
            inString = Console.ReadLine();
            id = Convert.ToInt32(inString);
            Console.Write("Please enter last name for " +
            "student {0} ", id);
            name = Console.ReadLine();
            Console.Write("Please enter grade point average ");
            inString = Console.ReadLine();
            gpa = Convert.ToDouble(inString);
        }
        public Student(int id, string name, double gpa)
        {
            IdNumber = id;
            LastName = name;
            GradePointAverage = gpa;
        }
        public Student()
            : this(0, "XXX", 0.0)
        {
        }
        int IComparable.CompareTo(object o)
        {
            int returnVal;
            Student temp = (Student)o;
            if(this.IdNumber > temp.IdNumber)
               returnVal = 1;
           else
             if(this.IdNumber < temp.IdNumber)
                 returnVal = -1;
             else
                 returnVal = 0;
            return returnVal;


        }
    }
}
