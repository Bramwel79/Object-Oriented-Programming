using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInsurance.cs
{
    class CarInsurance
    {
        
        public static void CalculatePremium(int age, string res)
        {
            if ((age < 16 || age > 80) && (res != "IL" || res != "WI"))
            {
                throw new ArgumentException()  ;
            }
             int totalCost = 0; 
             const int IL_BASE_PRICE = 100;
             const int WI_BASE_PRICE = 50;
             int additionalCost;
             additionalCost = (100 - age) * 3;

             if (res == "IL")
                 totalCost = IL_BASE_PRICE + additionalCost;
             else
                 totalCost = WI_BASE_PRICE + additionalCost;
             Console.WriteLine("Total premium due is " + totalCost.ToString ("c"));
        }

        static void Main(string[] args)
        {
            int driverAge;
            string residence;
            try
            {
                Console.Write("Enter Driver's age>> ");
                driverAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Driver's residence>> ");
                residence = Console.ReadLine();
                CalculatePremium(driverAge, residence);

            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
             
            Console.ReadLine();
        }
    }
}
