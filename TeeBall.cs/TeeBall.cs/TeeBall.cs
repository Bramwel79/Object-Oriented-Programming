using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall.cs
{
    class TeeBall
    {
        private static int errorInBaseNumber = 0;
        private static int errorInPlayerNumber = 0;
        static void Main(string[] args)
        {
            const int PLAYERS = 12;
            const int BASES = 5;
            int[,] teeBallScores = new int[PLAYERS, BASES];
            bool inputDone = false;


            do
            {
                inputDone = ReadScore(teeBallScores);

            } while (!inputDone);


            Console.WriteLine();
            Console.WriteLine("Tiny Tots Baseball League");
            Console.WriteLine("*************************");
            Console.WriteLine("Player Summary");
            Console.WriteLine("**************");
            Console.WriteLine("Player     Bases");
            Console.WriteLine("          Zero      One       Two       Three     Four");
            for (int i = 0; i < PLAYERS; ++i)
            {

                Console.Write("{0}", i);
                for (int j = 0; j < BASES; ++j)
                {

                    Console.Write("{0,10:D}", teeBallScores[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("During the data entry process, there were");
            Console.WriteLine(errorInPlayerNumber + " error(s) in player numbers and\n" + errorInBaseNumber + " errors(s) in base numbers");
            Console.ReadLine();
        }

        private static bool ReadScore(int[,] teeBallScores)
        {
            const int SENTINEL_VALUE = 99;
            bool playerNumberGood = false;
            bool playerBaseGood = false;
            int playerNumber = -1;
            int playerBase = -1;


            while (!playerNumberGood)
            {
                Console.Write("Enter Player Number>>  ");
                string playerNo = Console.ReadLine();

                try
                {
                    playerNumber = Convert.ToInt32(playerNo);
                    if ((playerNumber < 0 || playerNumber >= 12) && (SENTINEL_VALUE != playerNumber)) throw new Exception();

                    playerNumberGood = true;


                }
                catch
                {
                    Console.WriteLine("****Error in player number: {0} is too high", playerNumber);
                    Console.WriteLine("****Enter a number between 0 and 11 or 99 to quit.");
                    ++errorInPlayerNumber;

                    continue;

                }

            }
            if (SENTINEL_VALUE == playerNumber) return false;

            while (!playerBaseGood)
            {
                Console.Write("Enter Base Hits for Player Number {0} >> ", playerNumber);
                string hits = Console.ReadLine();

                try
                {
                    playerBase = Convert.ToInt32(hits);
                    if ((playerBase < 0 || playerBase >= 5) && (SENTINEL_VALUE != playerBase)) throw new Exception();
                    playerBaseGood = true;


                }
                catch
                {
                    Console.WriteLine("***Error in number of bases: {0} is too high", playerBase);
                    Console.WriteLine("***Enter a number between 0 and 4 or 99 to quit");
                    ++errorInBaseNumber;
                    continue;

                }



            }

            if (SENTINEL_VALUE == playerBase) return false;
            teeBallScores[playerNumber, playerBase]++;

            return true;
        }
    }
}
