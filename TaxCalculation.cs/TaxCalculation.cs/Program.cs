// program to demonstrate method overloading.
// calculate tax by passing in the tax rate as a double figure nad later as a percentage
// #70587872 Bramwel Nawate Abuko

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace TaxCalculation.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTax(79.95,0.06);
            CalculateTax(79.95,6);
            Console.ReadLine();
        }
        static void CalculateTax(double price, double taxRate)
        {
            double tax;
            tax = price * taxRate ;
            Console.WriteLine("Tax computed using  2 Formal Parameters of double type");
            Console.WriteLine("The tax is {0}", tax.ToString ("c"));
        }
        static void CalculateTax(double price, int taxRate)
        {
            double taxRateConverted = taxRate / 100.00;
            double tax;
            tax = price * taxRateConverted;
            Console.WriteLine("Tax computed using 2 Formal Parameters of double and int type");
            Console.WriteLine("The tax is {0}", tax.ToString ("c"));
        }

    }
}
