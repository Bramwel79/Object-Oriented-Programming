using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int drawers;
            GetNumberOfDrawers(out drawers);
            char wood ;
            GetTypeOfWood(out wood);
            int cost  ;
            CalculateCostOfDesk(ref drawers, ref wood,out cost);
            DisplayDetails(  drawers ,  wood ,  cost );

        }
        static void GetNumberOfDrawers(out int numberOfDrawers)
        {
           
            Console.Write("Enter the number of drawers in the desk >> ");
            numberOfDrawers  = Convert.ToInt32(Console.ReadLine () );
            
        }
        static void GetTypeOfWood(out char typeOfWood)
        {
            
            Console.WriteLine("The Wood types are m for mahogany, o for oak and p for pine");
            Console.Write("Enter the type of wood >> ");
            typeOfWood = Convert.ToChar(Console.ReadLine());
            

        }
        static void CalculateCostOfDesk(ref int numberOfDrawers, ref char typeOfWood,out int costOfDesk)
        {
            
            switch (typeOfWood)
            {
                case 'p':
                    costOfDesk = (100 + (numberOfDrawers * 30));
                    break;
                case 'o':
                    costOfDesk = (140 + (numberOfDrawers * 30));
                    break;
                default:
                    costOfDesk = (180 + (numberOfDrawers * 30));
                    break;
            }

            /*if (typeOfWood == 'p')
            {
                costOfDesk = (100 + (numberOfDrawers * 30));

            }
            else

                if (typeOfWood == 'o')
                {
                    costOfDesk = (140 + (numberOfDrawers * 30));
                }
                else
                {
                    costOfDesk = (180 + (numberOfDrawers * 30));
                }
        }*/
            

        }
        static void DisplayDetails(int drawers,char wood,int cost)
        {
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("The number of drawers are {0}",drawers  );
            Console.WriteLine("The type of wood is {0}",wood  );
            Console.WriteLine("The cost of desk is {0}",cost );
            Console.WriteLine("*********************************");
            Console.ReadLine();
        
        }
    }
}
