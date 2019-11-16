using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Scenes
    {
        public static void Wake()
        {
            Clear();
            WriteLine("Some time has passed... and you wake up.");

            WriteLine("You have 2 choices on you...\n 1) Explore your suroundings \n or... \n 2) panic ");

            string choice = ReadLine();
            if (choice == "1")
            {
                Forest();
            }
            else if (choice == "2")
            {
                Game.GameOver();
            }
        }
        public static void Forest()
        {
            Clear();

            string choice = ReadLine();
            if (choice == "1")
            {
                Forest();
            }
            else if (choice == "2")
            {
                Cave();
            }
            else if (choice == "3")
            {
                Game.GameOver();
            }
        }

        public static void Cave()
        {
            Clear();

            string choice = ReadLine();
            if (choice == "1")
            {
                Forest();
            }
            else if (choice == "2")
            {
                Mountain();
            }
            else if (choice == "3")
            {
                Game.GameOver();
            }
        }

        public static void Mountain()
        {
            Clear();

            string choice = ReadLine();
            if (choice == "1")
            {
                Forest();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                Game.GameOver();
            }
        }
    }
}
