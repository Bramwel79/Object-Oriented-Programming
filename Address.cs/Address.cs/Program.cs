using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Bramwel Nawate Abuko";
            String streetAddress = "Karanja Road, Kibera";
            String city = "Nairobi";
            String state = "Kenya";

            Console.WriteLine("My Full Name is " + fullName);
            Console.WriteLine("The Street Address is " + streetAddress);
            Console.WriteLine("The City and State is {0},{1}", city, state);
            Console.ReadLine();
        }
    }
}
