using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TapeDemo.cs
{
    class TapeDemo
    {
        static void Main(string[] args)
        {
            Tape magnetic = new Tape();
            magnetic.LengthInInches = 23;
            magnetic.WidthInInches = 15;
            Console.WriteLine(magnetic.ToString());
            Console.WriteLine();

            VideoTape runningMan = new VideoTape();
            runningMan.LengthInInches = 12;
            runningMan.WidthInInches = 4;
            runningMan.PlayingTimeInMinutes = 95;
            Console.WriteLine(runningMan.ToString());
            Console.WriteLine();

            AdhesiveTape brownTape = new AdhesiveTape();
            brownTape.LengthInInches = 19;
            brownTape.WidthInInches = 10;
            brownTape.SticknessFactor = 20;
            Console.WriteLine(brownTape.ToString() +  "\nand the stickness factor is " + brownTape .SticknessFactor );
            //Console.WriteLine();
            Console.ReadLine();

        }
    }
    public class Tape
    {
        private int lengthInInches;
        private int widthInInches;


        public int LengthInInches
        {
            get
            {
                return lengthInInches;
            }
            set
            {
                lengthInInches = value;
            }


        }
        public int WidthInInches
        {
            get
            {
                return widthInInches;
            }
            set
            {
                widthInInches = value;
            }
        }

        public new string ToString()
        {
            return ("The type of object is " + GetType() + "\nThe Length in inches of object is " + LengthInInches +
                    " the Width in inches of object is " + WidthInInches);
  
        }
    }

    public class VideoTape : Tape
    {
        int playingTimeInMinutes;

        public int PlayingTimeInMinutes
        {
            get
            {
                return playingTimeInMinutes;
            }
            set
            {
                playingTimeInMinutes = value;
            }
        }
    }

    public class AdhesiveTape : Tape
    {
        int sticknessFactor;

        public int SticknessFactor
        {
            get
            {
                return sticknessFactor;
            }
            set
            {
                if (value < 1 || value > 10)
                    sticknessFactor = 5;
                else
                    sticknessFactor = value;
            }
        }
    }
}
