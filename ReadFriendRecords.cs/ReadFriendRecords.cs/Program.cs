using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFriendRecords.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            const char DELIMITER = ',';
            const string FILENAME = "Friends.txt";
            Friend friend = new Friend();
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(DELIMITER);
                friend.FirstName = fields[0];
                friend.LastName = fields[1];
                friend.TelephoneNumber = fields[2];
                friend.BirthdayMonth = Convert.ToInt32(fields[3]);
                friend.BirthdayDay = Convert.ToInt32(fields[4]);
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            Console.ReadLine();
        }
    }
    class Friend
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; set; }


    }
}
