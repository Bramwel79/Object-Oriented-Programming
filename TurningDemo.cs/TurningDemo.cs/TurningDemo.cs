using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurningDemo.cs
{
    class TurningDemo
    {
        static void Main(string[] args)
        {
            Page page = new Page();
            Console.Write("Page says ");
            page.Turn();
            Console.WriteLine();
            Corner corner = new Corner();
            Console.Write("corner says ");
            corner.Turn();
            Console.WriteLine();
            Pancake pancake = new Pancake();
            Console.Write("pancake says ");
            pancake.Turn();
            Console.WriteLine();
            Leaf leaf = new Leaf();
            Console.Write("leaf says ");
            leaf.Turn();
            Console.ReadLine();

        }
    }
    public interface ITurnable
    {
        void Turn();
    }
    public class Page : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a page in a book.");
        }
    }
    public class Corner : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a corner while driving.");
        }
    }
    public class Pancake : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a pancake while frying it.");
        }
    }
    public class Leaf : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a leaf after learning the hard way.");
        }
    }
}
