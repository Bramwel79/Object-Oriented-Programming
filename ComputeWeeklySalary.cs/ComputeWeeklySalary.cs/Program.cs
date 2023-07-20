using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputeWeeklySalary.cs
{
    class Program
    {
        const int WEEKS_IN_A_YEAR = 52;
        static void Main(string[] args)
        {
            CalculateWeeklySalary(120000);
            CalculateWeeklySalary(450000.55);
            Console.ReadLine();
        }
        static void CalculateWeeklySalary(int annualSalary)
        {
            int weeklySalary = annualSalary / WEEKS_IN_A_YEAR;
            Console.WriteLine("The weekly salary is {0}", weeklySalary.ToString ("c"));
        }
        static void CalculateWeeklySalary(double annualSalary)
        {
            double weeklySalary = annualSalary / WEEKS_IN_A_YEAR;
            Console.WriteLine("The weekly salary is {0}", weeklySalary.ToString ("c"));
        }
    }
}
