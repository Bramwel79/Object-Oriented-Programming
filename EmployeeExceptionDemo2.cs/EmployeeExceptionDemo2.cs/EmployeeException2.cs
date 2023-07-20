using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeExceptionDemo2.cs
{
    class EmployeeException2
    {
        static void Main(string[] args)
        {
                Employee[] employees = new Employee[5];
                const int INVALIDIDNUM = 999;
                int id;
                double hourly;

                for (int x = 0; x < employees.Length; ++x)
                {
                    try
                    {
                        Console.Write("Enter Employee Id Num>> ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Employee Hourly Wage>> ");
                        hourly = Convert.ToDouble(Console.ReadLine());
                        employees[x] = new Employee(id, hourly);
                        Console.WriteLine();
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                        employees[x] = new Employee(INVALIDIDNUM, Employee.LOWWAGE);
                    }
                    catch (ArgumentException ag)
                    {
                        Console.WriteLine(ag.Message);
                        employees[x] = new Employee(INVALIDIDNUM, Employee.LOWWAGE);
                    }
                }
                Console.WriteLine();
                for (int y = 0; y < employees.Length; ++y)
                {
                    Console.WriteLine(employees[y].ToString ());
                }
                Console.ReadLine();
            }
            
            
        }
    }
    public class Employee
    {
        int idNum;
        double hourlyWage;
        public const double LOWWAGE = 6.00;
        public const double HIGHWAGE = 50.00;
        
       
        public Employee(int id, double wage)
        {
            idNum = id;
            hourlyWage = wage;
            if (hourlyWage  < LOWWAGE  || hourlyWage  > HIGHWAGE )
              throw new ArgumentException();
        }
        public new string ToString()
        {
            return ("Employee no " + idNum  + " earns " + hourlyWage .ToString ("c") + " per hour.");
        }
        
        
    }


