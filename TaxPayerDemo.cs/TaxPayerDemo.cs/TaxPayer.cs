using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxPayerDemo.cs
{
    class TaxPayer
    {
        String ssn;
        double yearlyGrossIncome;
        double taxOwed;

        

        public String SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }
        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }
            set
            {
                yearlyGrossIncome = value;
                CalculateTax ();
            }
        }
        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }
        private void CalculateTax()
        {
            if (yearlyGrossIncome < 30000)
                {
                    taxOwed = 0.15 * yearlyGrossIncome;
                }
                else
                {
                    taxOwed = 0.28 * yearlyGrossIncome;
                }

        }
        public static void Display(TaxPayer[] taxPayer)
        {
            int y;
            for (y = 0; y < taxPayer.Length; ++y)
            {
                Console.WriteLine("The details for paye object " + (y+1) + " is as follows");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Social Security Number is {0}\nYearly Gross Income is {1}\nand Tax is {2}",taxPayer[y].SSN ,taxPayer[y].YearlyGrossIncome.ToString ("c") ,taxPayer[y].TaxOwed .ToString ("c") );
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x;
            TaxPayer[] paye = new TaxPayer[10];
            for (x = 0; x < paye.Length; ++x)
            {
                paye[x] = new TaxPayer() ;
                Console.Write("Enter the social security number for object number {0}: ",x +1);
                paye[x].SSN  = Console .ReadLine ();
                Console.Write ("Enter Yearly Gross Income for object number {0}: ",x +1);
                paye [x].YearlyGrossIncome  = Convert .ToDouble (Console.ReadLine ());
                
            }
            Console.WriteLine();
            Display(paye);
            Console.ReadLine ();

        }
    }
}
