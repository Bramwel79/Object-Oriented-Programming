using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeExceptionDemo.cs
{
    class EmployeeException
    {
        static void Main(string[] args)
        {
            try
            {
               Employee Mudachi = new Employee(002, 55.00);
               Employee Migoye = new Employee(001, 5.00);
               Employee David = new Employee(007, 35.00);
            }
            catch (ArgumentException ag)
            {
                Console.WriteLine(ag.Message);
                Console.WriteLine("Employee hourly wage is not within prescribed limits.");
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        int idNum;
        double hourlyWage;
        public Employee(int id, double wage)
        {
            idNum = id;
            hourlyWage = wage;
            if (wage < 6.00 || wage > 50.00)
                throw new ArgumentException();
            else
              Console.WriteLine("Employee no " + id + " earns " + wage.ToString ("c") + " per hour.");
            
        }
    }

}
