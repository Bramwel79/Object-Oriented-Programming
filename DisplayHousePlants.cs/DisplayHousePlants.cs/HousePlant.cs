using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayHousePlants.cs
{
    class HousePlant
    {
        String plantName;
        double plantPrice;
        Boolean hasPlantBeenFed;

        public String PlantName
        {
            get
            {
                return plantName;
            }
            set
            {
                plantName = value;
            }
        }
        public double PlantPrice
        {
            get
            {
                return plantPrice;
            }
            set
            {
                plantPrice = value;
            }
        }
        public Boolean HasPlantBeenFed
        {
            get
            {
                return hasPlantBeenFed;
            }
            set
            {
                hasPlantBeenFed = value;
            }

        }
    }
        class DisplayHousePlants
        {
                     
            static void Main(string[] args)
            {
                HousePlant rose = new HousePlant();
                HousePlant guava = new HousePlant();
                HousePlant raspberry = new HousePlant();
                rose.PlantName = "white rose";
                rose.PlantPrice = 34.99;
                rose.HasPlantBeenFed = true;
                guava.PlantName = "popo";
                guava.PlantPrice = 78.99;
                guava.HasPlantBeenFed = false;
                raspberry.PlantName = "red berries";
                raspberry.PlantPrice = 23.99;
                raspberry.HasPlantBeenFed = true;
                Display(rose);
                Console.WriteLine();
                Display(guava);
                Console.WriteLine();
                Display(raspberry);
                Console.ReadLine();

            }
            static void Display(HousePlant plant)
            {
                Console.WriteLine("The House plant name is {0}", plant.PlantName);
                Console.WriteLine("The House plant price is {0}", plant.PlantPrice);
                Console.WriteLine("Has this plant been fed in the last month {0}", plant.HasPlantBeenFed);
                

            }
        }
    }
        

