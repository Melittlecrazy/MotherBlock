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
            WriteLine(@"
              
      ________    
 ()  |\       \    ()
  \\__ \ ______\__//
   \__) |       |_/
     |  |       |
      \ |       |
       \|_______|
  ");
            // the cube ascii art is from: https://www.asciiart.eu/art-and-design/geometries
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

            WriteLine("Despite how everything looks and you seemingly felt no damage to anything or your body." +
                "\n Give or take, you haven't stood up yet.");
            WriteLine();
            WriteLine("But while you contemplate getting up you hear a twig break somw where in the forest around you... ");

            WriteLine("Aside from the possible wet feeling in your.. pants? (Are you wearing pants? whatever...) " +
                "\n Well whatever it is that you have on, you feel wettness and the sudden choices come up" +
                "\n1) Try to befriend what ever it is that made you... wet. (give or take phrasing)" +
                "\n2) Flip out and run away" +
                "\n3) Do nothing");

            string choice = ReadLine();
            if (choice == "1")
            {
                Friends.Encounter();
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

            WriteLine("");

            WriteLine("Given the new layout you have, 3 options! Choose wisely... " +
                "\n(or don't, I'm not a cop)");

            WriteLine("1) Continue down the cave and hope for the best" +
                "\n2) Test you \"sweet\" break dancing skills" +
                "\n3) talk to that minor... (be causious they kinda smell...)");

            string choice = ReadLine();
            if (choice == "3")
            {
                Friends.Encounter();
            }
            else if (choice == "1")
            {
                Mountain();
            }
            else if (choice == "2")
            {
                Game.GameOver();
            }
        }

        public static void Mountain()
        {
            Clear();

            WriteLine("1) Hardcore Parkour our way up" +
                "\n2) Climb the mountain to reach the top" +
                "\n3) Give up and live in a shack (with your friends)");

            string choice = ReadLine();
            if (choice == "3")
            {
                Friends.Encounter();
            }
            else if (choice == "2")
            {
                End();
            }
            else if (choice == "1")
            {
                Game.GameOver();
            }
        }

        public static void End()
        {
            Clear();

            WriteLine("You have made it to the top! You can now join back with the MotherShip");
        }
    }
}
