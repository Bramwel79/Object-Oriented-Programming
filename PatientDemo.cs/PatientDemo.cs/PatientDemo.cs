using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientDemo.cs
{
    class PatientDemo
    {
        
        static void Main(string[] args)
        {
            Patient[] WrightstownHospitalPatients = new Patient [5];
            int x; 

            //fill array with 5 patients
            for (x = 0; x < WrightstownHospitalPatients.Length; ++x)
            {
                WrightstownHospitalPatients[x] = new Patient();
                Console.Write("Enter Patient's ID no: ");
                WrightstownHospitalPatients[x].IdNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Patient's name: ");
                WrightstownHospitalPatients[x].Name = Console.ReadLine();
                Console.Write("Enter Patient's Age: ");
                WrightstownHospitalPatients[x].Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Total Amount due: ");
                WrightstownHospitalPatients[x].Amount = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine();
            }
            //display array sorted by ID Number
            Console.WriteLine();
            Console.WriteLine("Wrightstown Hospital Billing Department");
            Console.WriteLine("****************************************");
            Array.Sort(WrightstownHospitalPatients);
            for (x = 0; x < WrightstownHospitalPatients.Length; ++x)
            {
                Console.WriteLine(WrightstownHospitalPatients[x].ToString());
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    public class Patient : IComparable 
    {
        public Patient()
        {
        }
        public Patient(int num, string name, int age, double cost)
        {
            IdNumber = num;
            Name = name;
            Age = age;
            Amount = cost;
        }
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return ("Patient's ID Number is " + IdNumber + "\nPatient's Name is " + Name +
                   "\nPatient's Age is " + Age + "\nAmount due is " + Amount );
        }
        int IComparable.CompareTo(Object o)
        {
            int result;
            Patient temp = (Patient)o;
            if (this.IdNumber > temp.IdNumber)
                result = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    result = -1;
                else
                    result = 0;
            return result;
        }
        public override int GetHashCode()
        {
            return IdNumber;
        }
        
    }
     

}
