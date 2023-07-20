using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallAndLarge.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int x = 0; x < numbers .Length ; ++x)
            {
                
                Console.Write("Enter an integer ");
                int numberEntered = Convert.ToInt32(Console.ReadLine());
                numbers[x] = numberEntered ;
            }
            DetermineSize(numbers);

        }
        static void DetermineSize(int[] arrayToSize)
        {
            
            int smallest = arrayToSize [0];
            int largest = arrayToSize [0] ;
            for(int i = 0;i < arrayToSize .Length ;++i)
            {
                if (arrayToSize[i] < smallest)
                    smallest = arrayToSize[i];
                else
                    if (arrayToSize[i] > largest)
                        largest = arrayToSize[i];
                
            }
            Console.WriteLine("The largest number is {0} and smallest is {1}", largest, smallest);
            Console.ReadLine();
        }
    }
}
