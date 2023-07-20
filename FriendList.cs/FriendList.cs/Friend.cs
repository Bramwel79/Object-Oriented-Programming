﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FriendList.cs
{
    class Friend : IComparable 
    {
        String nameOfFriend;
        int phoneNumber;
        int friendsBirthdayMonth;
        int friendsBirthdayDay;
        int friendsBirthdayYear;

        public String NameOfFriend
        {
            get
            {
                return nameOfFriend;
            }
            set
            {
                nameOfFriend = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public int FriendsBirthdayMonth
        {
            get
            {
                return friendsBirthdayMonth;
            }
            set
            {
                if (friendsBirthdayMonth > 12)
                    friendsBirthdayMonth = 12;
                else
                friendsBirthdayMonth = value;
            }
        }
        public int FriendsBirthdayDay
        {
            get
            {
                return friendsBirthdayDay;
            }
            set
            {
                friendsBirthdayDay = value;
            }
        }
        public int FriendsBirthdayYear
        {
            get
            {
                return friendsBirthdayYear;
            }
            set
            {                                 
                friendsBirthdayYear = value;
            }
        }
        int IComparable.CompareTo(object o)
        {
            int returnVal;
            Friend temp = (Friend)o;
            returnVal =  this.NameOfFriend.CompareTo(temp.NameOfFriend );
            return returnVal;
         }

        static void Main(string[] args)
        {
            Friend[] mates = new Friend[8];
            for (int x = 0; x < mates.Length; ++x)
            {
                mates[x] = new Friend();
                Console.Write("Enter Friend's Name ");
                mates[x].NameOfFriend = Console.ReadLine();
                Console.Write("Enter Friend's Phone Number ");
                mates[x].PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Friend's Birthday Month ");
                mates[x].FriendsBirthdayMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Friend's Birthday Day ");
                mates[x].FriendsBirthdayDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Friend's Birthday Year ");
                mates[x].FriendsBirthdayYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***********Friends' data is as follows*********");
            DisplayFriendsData(mates);
            
            Console.ReadLine();
        }
        public static void DisplayFriendsData(Friend[] friend)
        {
            Array.Sort(friend);
            for (int y = 0; y < friend.Length; ++y)
            {
                Console.WriteLine("Friend no " + (y+1) + " name is " + friend[y].NameOfFriend);
                Console.WriteLine("Friend no " + (y+1) + " phone number is " + friend[y].PhoneNumber);
                Console.WriteLine("Friend no " + (y+1) + " birthday month is " + friend[y].FriendsBirthdayMonth);
                Console.WriteLine("Friend no " + (y+1) + " birthday day is " + friend[y].FriendsBirthdayDay);
                Console.WriteLine("Friend no " + (y+1) + " friend's birthday year is " + friend[y].FriendsBirthdayYear);
                Console.WriteLine();
            }
        }
    }
}
