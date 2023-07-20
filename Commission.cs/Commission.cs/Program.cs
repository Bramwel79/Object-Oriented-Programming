using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission
{
     class Program
    {
       
        
         static void Main(string[] args)
        {
            double totalSales;
            double totalCommission;
            totalSales   = DailySalesValue() ;
            totalCommission = CalculateSalesCommission(totalSales   );
            Console.WriteLine("Total Daily Sales are {0} and the Sales Person Commission Due is {1}",totalSales .ToString ("c"), totalCommission.ToString ("c"));
            Console.ReadLine();
            
        }

      public static double DailySalesValue()
        {
            double dailySales;
            Console.Write("Enter the Daily Sales Value ");
            dailySales = Convert.ToDouble (Console.ReadLine());
            return dailySales;
        }

       public static double CalculateSalesCommission(double salesAmount)
        {
           
           int[] salesLowerLimit = { 0, 1000, 3000 };
           double[] commissionRate = { 0.03, 0.04, 0.05 };
           int sub = salesLowerLimit.Length - 1;
           double commissionDue = 0;

           while(sub > 0 && salesAmount < salesLowerLimit [sub])
           {
             --sub;
           }
           commissionDue = (salesAmount * commissionRate[sub]);
           return commissionDue;
        }

    }
}
