using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleArrayMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 12, 17, 34, 59, 57 };
            int[] arrayTwo = { 10, 45, 23 };
            int[] arrayThree = { 12, 98, 34, 55 };
            DisplayArrayAndTheirSum(arrayOne);
            DisplayArrayAndTheirSum(arrayTwo);
            DisplayArrayAndTheirSum(arrayThree);
            Console.ReadLine();
        }
        static void  DisplayArrayAndTheirSum(int[] arrayToDisplay)
        {
            int x;
            int sum = 0;
            for( x = 0;x < arrayToDisplay .Length ;++x)
            {
                
                sum += arrayToDisplay[x];
                Console.WriteLine("The array members are {0}", arrayToDisplay[x]);
            }
            
            Console.WriteLine("Their sum is {0}", sum);
            
        }
    }
}
