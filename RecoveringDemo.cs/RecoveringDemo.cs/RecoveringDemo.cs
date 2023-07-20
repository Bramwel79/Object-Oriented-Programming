using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecoveringDemo.cs
{
    class RecoveringDemo
    {
        static void Main(string[] args)
        {
            Patient pat = new Patient();
            Console.Write("pat says ");
            pat.Recover();
            Console.WriteLine();
            Furniture table = new Furniture();
            Console.Write("table says ");
            table.Recover();
            Console.WriteLine();
            Football uefa = new Football();
            Console.Write("uefa says ");
            uefa.Recover();
            Console.ReadLine();
        }
    }
    public interface IRecoverable
    {
        void Recover();

    }
    public class Patient : IRecoverable
    {
         public void Recover()
        {
            Console.WriteLine ("An apple a day made me feel well.");
        }
      
    }
    public class Furniture : IRecoverable
    {
        public void  Recover()
        {
            Console.WriteLine ("Offer expires tomorrow.");
        }
    }
    public class Football : IRecoverable
    {
        public void Recover()
      {
          Console.WriteLine  ("Offence committed.");
      }
    }
}
