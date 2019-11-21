using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Friends
    {
        public static int GainedFriend = 0;
        public static bool HasFriend = false;
        static string[] friendEncounter = new string[] { "Goat, that's lost", "Wolf, that was thrown out of it's pack", "Squrrel, that's friendly and want's a home", "Bat, that doesn't know where it is", "Jesus, that's lost and doesn't mind joining any one trying to be a friend", "Kiwi, that doesn't know how it got where it is but is friendly and wants a friend" };
        static Random encountor = new Random();
        
        public static bool Encounter()
        {
        int index = encountor.Next(friendEncounter.Length);
            WriteLine($"Hey, it's a {friendEncounter[index]}. Looks a bit lonely...");

            WriteLine(" 1) Befriend \n 2) Murder");
            string choice = ReadLine();
            if(choice == "1")
            {
                GainedFriend ++;
                HasFriend = true;
                return (HasFriend);
                //I wanted to have it to where it goes back to the path but I don't know how
            }
            else if (choice == "2")
            {
                WriteLine("Wow... That's dark... I'm just gonna take you out of this situation...");
                WriteLine();
                WriteLine("You just go ok fine and press anu key to continue...");
                return (HasFriend);

            }
            return (HasFriend);
        }

        public static void NumOfFriends()
        {
            WriteLine(GainedFriend);
        }
        //the website that helped with random :https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings/

    }
}