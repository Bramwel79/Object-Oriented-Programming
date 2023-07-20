/* Bramwel Nawate Abuko
 * #70587872
 * program will demonstrate use of abstract class and interfece
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesPersonDemo.cs
{
    class SalesPersonDemo
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson Dickson = new RealEstateSalesperson();
            RealEstateSalesperson Penina = new RealEstateSalesperson();
            Dickson.SalesSpeech();
            Console.WriteLine();
            Dickson.DisplaySalespersonFullName();
            Console.WriteLine();
            Dickson.MakeSale();
            Console.WriteLine();

            Penina.SalesSpeech();
            Console.WriteLine();
            Penina.DisplaySalespersonFullName();
            Console.WriteLine();
            Penina.MakeSale();
            Console.WriteLine();

            GirlScout Nancy = new GirlScout();
            Nancy.SalesSpeech();
            Console.WriteLine();
            Nancy.DisplaySalespersonFullName();
            Console.WriteLine();
            Nancy.MakeSale();

            Console.ReadLine();
        }
    }
    public abstract class Salesperson
    {
        public const string SPACE = " ";
        string firstName;
        string lastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Salesperson()
        {
        }
        public Salesperson(string first, string last)
        {
            FirstName  = first;
            LastName = last;
        }
        public void DisplaySalespersonFullName()
        {
            try
            {
                Console.Write("Enter Salesperson First Name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter Salesperson Last Name: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Salesperson full name is " + firstName + SPACE + lastName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
    public class RealEstateSalesperson : Salesperson,ISellable 
    {
        double totalValueSold = 0;
        double totalCommissionEarned = 0;
        double commissionRate;
        double houseValue;
       

        public double TotalValueSold { get; set; }
        public double TotalCommissionEarned { get; set; }
        public double CommissionRate { get; set; }

        public RealEstateSalesperson()
        {
        }
        public RealEstateSalesperson(string first,string last,double commsRate): base(first ,last )
        {
            CommissionRate  = commsRate ;
        }
        public void SalesSpeech()
        {
            Console.WriteLine("Real Estate is an art");
            Console.WriteLine("you can never go wrong with.");
            Console.WriteLine("****************************");
        }
        public void MakeSale()
        {
            try
            {
                Console.Write("Enter Dollar value of house: ");
                houseValue = Convert.ToInt32(Console.ReadLine());
                totalValueSold += houseValue;
                Console.Write("Enter the Commission Rate e.g 0.12 for 12%: ");
                commissionRate = Convert.ToDouble(Console.ReadLine());
                totalCommissionEarned += totalValueSold * commissionRate;
                Console.WriteLine("Total Value sold is " + totalValueSold +
                    "\nTotal Commission earned is " + totalCommissionEarned);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class GirlScout : Salesperson,ISellable 
    {
        int cookieBoxesSold = 0;
        int boxes;
        
        public int CookieBoxesSold{get;set;}

        public GirlScout()
        {
        }

        public GirlScout(string first, string last, int cookieBoxes)
            : base(first, last)
        {
            CookieBoxesSold = cookieBoxes;
        }
        public void SalesSpeech()
        {
            Console.WriteLine("Girl Scout movement is fundamental\nin the advancement of humanity socially.");
            Console.WriteLine("*********************************");
        }
        public void MakeSale()
        {
            try
            {
                Console.Write("Enter number of cookie boxes sold: ");
                boxes = Convert.ToInt32(Console.ReadLine());
                cookieBoxesSold += boxes;
                Console.WriteLine("Total Cookie Boxes sold are " + cookieBoxesSold);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
    public interface ISellable
    {
        void SalesSpeech();
        void MakeSale();
    }
}
