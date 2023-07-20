using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongWords.cs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] words = {"tiger","cheetah","leopard","lion","redscorpion","bluewhale",
                              "elephant","whiterhino","blackrhino","tilapia","bear","lizard"                           
                             };
            int clientStringLength;
            

            try
            {
                Console.Write("Enter a minimum string length>> ");
                clientStringLength = Convert.ToInt32(Console.ReadLine());
                var word = from y in words
                           where y.Length >= clientStringLength
                           select y;
                if (word.Count() == 0) // no string is atleast as long as client input
                {
                    Console.WriteLine("No string is that long");
                }
                else
                    if (word.Count() > 0)
                    {
                        Console.WriteLine("The string's length that are atleast {0} long are:", clientStringLength);
                        Console.WriteLine("**************************************************");
                        foreach (var y in word)
                        {
                            Console.WriteLine("{0}", y);
                        }
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

           
            Console.ReadLine();
        }
    }
}
