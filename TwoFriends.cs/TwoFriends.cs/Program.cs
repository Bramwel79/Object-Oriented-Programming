using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoFriends.cs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String firstName = "David";
            String secondName = "Nancy";

            Console.WriteLine("Example to show how String.Compare method works:");
            Console .WriteLine ();
            Console.WriteLine("Compare {0} to {1} : {2}",
                firstName,secondName,String.Compare(firstName, secondName));
            Console.WriteLine("Result of -1 means that David is less than Nancy lexically.");
            Console.ReadLine();
        }
    }
}
