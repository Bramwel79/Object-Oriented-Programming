using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AccessSomeNames.cs
{
    class AccessSomeNames
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            const int END = 999;
            int count = 0;
            int num;
            int size;
            string name;

            name = reader.ReadLine();
            while (name != null)
            {
                ++count;
                name = reader .ReadLine ();
            }
            size = (int)file.Length / count;

            Console.Write("\nWith which number do you want to start >> ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != END)
            {
                Console.WriteLine("Starting with name " + num + ": ");
                file.Seek((num - 1) * size, SeekOrigin.Begin);
                name = reader.ReadLine();
                Console.WriteLine(" " + name);
                while (name != null)
                {
                    name = reader.ReadLine();
                    Console.WriteLine(" " + name);
                }
                Console.WriteLine("\nWith which number do you " +
                    "want to start?");
                Console.Write(" (Enter " + END + " to quit) >> ");
                num = Convert.ToInt32(Console.ReadLine());

                
            }
            reader.Close();
            file.Close();
        }
    }
}
