using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credit.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerCreditLimit();
            CustomerCreditLimit(25000.65);
            Console.ReadLine();
        }
        static void CustomerCreditLimit(double credit = 500)
        {
            Console.WriteLine("Amount of credit granted to customer is {0}", credit);

        }
        
    }
}
