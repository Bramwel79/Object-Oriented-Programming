using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOnPurpose.cs
{
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            int answer ;
            int result = 0;
            int zero = 0;
            try
            {
                Console.Write("Enter an integer >> ");
                answer = Convert.ToInt32(Console.ReadLine());
                result = answer / zero;
                         
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.WriteLine("The answer is " + result);
            Console.ReadLine();  
            
        }
    }
}
