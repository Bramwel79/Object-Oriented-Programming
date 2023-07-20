using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TestFileAndDirectory.cs
{
    class Program
    {
        const string END_PROGRAM = "end";
        

        static void Main(string[] args)
        {
            string directoryName;
            string fileName;
            string [] listOfFiles;
            Console.Write("Enter a directory or end to quit >> ");
            directoryName = Console.ReadLine();
            while (directoryName != END_PROGRAM)
            {
                if (Directory.Exists(directoryName))
                {
                    Console.WriteLine("Directory " + directoryName + " exists and contains the following files:");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int x = 0; x < listOfFiles.Length; ++x)
                    {
                        Console.WriteLine("{0}", listOfFiles[x]);
                    }
                    Console.Write("Enter a file name >> ");
                    fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine("File exists");
                        Console.WriteLine("File was created " + "{0}", File.GetCreationTime(fileName));
                    }
                    else
                    {
                        Console.WriteLine("File does not create");
                    }
                }
                else
                {
                    Console.WriteLine("Directory does not exist");
                }
                Console.Write("Enter a directory or end to quit >> ");
                directoryName = Console.ReadLine();
            }
            Console.ReadLine();
            
        }
    }
}
