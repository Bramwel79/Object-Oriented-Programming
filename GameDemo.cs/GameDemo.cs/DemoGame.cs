using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDemo.cs
{
    public class GameDemo
    {

        static void Main(string[] args)
        {
            Game footBall = new Game();
            footBall.GameName = "Uefa champions league";
            footBall.MaxNumberOfPlayers = 22;
            Console.WriteLine(footBall.ToString());
            Console.WriteLine();
            GameWithTimeLimit chess = new GameWithTimeLimit();
            chess.GameName = "Chess championship";
            chess.MaxNumberOfPlayers = 2;
            chess.GameTimeLimitInMinutes = 35;
            Console.WriteLine(chess.ToString() + "\nGame time in Minutes is " + chess.GameTimeLimitInMinutes);
            Console.ReadLine();
        }
    }

        public class Game
        {
            public string GameName { get; set; }
            public int MaxNumberOfPlayers { get; set; }
            public new string ToString()
            {
                return (GetType() + " " + "\nName of game is " + GameName +
                    "\nNumber of players is " + MaxNumberOfPlayers);
            }

        }
        public class GameWithTimeLimit : Game
        {
            public int GameTimeLimitInMinutes { get; set; }
        }
    }
