using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsDemo.cs
{
    class Car
    {
        int carIDNumber;
        String carMake;
        String carModel;
        String carColour;
        double carValue;

        Car(int id,String make,String model,String colour,double value)
        {
            carIDNumber = id;
            carMake = make;
            carModel = model;
            carColour = colour;
            carValue = value;
        }
        public int CarIDNumber
        {
            get
            {
                return carIDNumber;
            }
        }
        public String CarMake
        {
            get
            {
                return carMake;
            }
        }
        public String CarModel
        {
            get
            {
                return carModel;
            }
        }
        public String CarColour
        {
            get
            {
                return carColour;
            }
        }
        public double CarValue
        {
            get
            {
                return carValue;
            }
        }
        static void Main(string[] args)
        {
            Car toyota = new Car(667, "landcruiser", "suv", "yellow", 23999.99);
            Car subaru = new Car(345, "impreza", "saloon", "blue", 12999.99);
            Car benz = new Car(007, "c-class", "saloon", "black", 45999.99);
            Car peugeot = new Car(299, "505", "station wagon", "beige", 13999.99);
            Car ferrari = new Car(277, "speed", "sports", "red", 35999.99);
            Car[] types = { benz, peugeot, ferrari };
            DisplayFleet(types);
            Console.ReadLine();
        }

        public static void DisplayFleet(Car[] car)
        {
            double totalCarValue = 0;
            for (int x = 0; x < car.Length; ++x)
            {
                Console.WriteLine("The value for Car object " + (x + 1) + " is {0}", car[x].CarValue.ToString ("c"));
                totalCarValue += car[x].CarValue;
            }
            Console.WriteLine("The total Car Value is {0}", totalCarValue.ToString ("c"));
        }
    }
}
