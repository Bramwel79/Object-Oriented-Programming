using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SplitAlphabet.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choice = {"alberto","babis","celo","davide","eugenio",
                               "fabbio","giorgio","helen","ines","june","ugo",
                               "polizzy","zarbo","nadia","ottelo","pepe","queen","rosella",
                               "steve","tommaso"};
            var wordChoice = from y in choice
                              group y by String.Compare(y, "n") < 0;
                              
            
            foreach (var firstGroup in wordChoice)
            {
                Console.WriteLine("Words in first part of alphabet are:{0}", firstGroup.Key);
                 foreach (var x in firstGroup)
                    Console.WriteLine("  {0}", x);
                 Console.WriteLine("Count is {0}",firstGroup.Count());
                
            }
            Console.ReadLine();

        }
    }
}
