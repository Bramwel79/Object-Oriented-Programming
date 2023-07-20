using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileComparison.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int textFileSize;
            int wordFileSize;
            int ratio;
            string textFileName = @"C:\Users\Bram\Documents\Visual Studio 2010\Projects\FileComparison.cs\FileComparison.cs\Quote.txt";
            string wordFileName = @"C:\Users\Bram\Documents\Visual Studio 2010\Projects\FileComparison.cs\FileComparison.cs\Quote.docx";
            FileInfo textInfo = new FileInfo(textFileName);
            FileInfo wordInfo = new FileInfo(wordFileName);

            Console.WriteLine("Size of text file is " + textInfo.Length);
            Console.WriteLine("Size of word file is " + wordInfo.Length);
            textFileSize = Convert .ToInt32 ( textInfo.Length);
            wordFileSize = Convert.ToInt32(wordInfo.Length);

            if (wordFileSize > textFileSize)
            {
                ratio = wordFileSize / textFileSize;
                Console.WriteLine("Ratio is  1: " + ratio);
            }
            else
            {
                ratio = wordFileSize / textFileSize;
                Console.WriteLine("Ratio is  " + ratio + " : 1");
            }
            

            Console.ReadLine();
        }
    }
}
