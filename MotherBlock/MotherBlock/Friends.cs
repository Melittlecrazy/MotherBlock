using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Friends
    {
        
        public static bool HasFriend = false;
        static string[] friendEncounter = new string[] { "", "" };
        static Random encountor = new Random();
        int index = encountor.Next(friendEncounter.Length);
        
        public static void Encounter()
        {
            WriteLine("{encountor[index]}");

            WriteLine(" 1) Befriend \n 2) Murder");
            string choice = ReadLine();
            if(choice == "1")
            {
                
                HasFriend = true;
            }
            else if (choice == "2")
            {
                WriteLine("Wow... That's dark... ");
            }
        }   
        //the website that helped with random :https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings/

    }
}