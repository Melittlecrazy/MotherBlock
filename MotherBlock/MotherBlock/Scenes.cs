using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Scenes
    {
        static bool Friend = false;
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
            WriteLine("You think to yourself in a slight dazed feel,\"Okay, I'm okay... " +
                "\nlet's assess the the situation: I fell off the MotherShip, I fell for what seems like a while... I need to make sure I remember my name...\" " +
                "What's your name?");

            string playerName = ReadLine();
            Player currentPlayer = new Player(playerName);
            WriteLine();
            WriteLine("Oh right I'm " + currentPlayer.Name + ". Now... where am I?");
            WriteLine();
            WriteLine("But while you contemplating getting up you hear a twig break some where in the forest around you... ");
            WriteLine();
            WriteLine("Aside from the possible wet feeling in your.. pants? (Are you wearing pants? whatever...) " +
                "\n Well whatever it is that you have on, you feel wettness and the sudden choices come up" +
                "\n1) Try to befriend what ever it is that made you... wet. (give or take phrasing)" +
                "\n2) Flip out and run away" +
                "\n3) Do nothing");

            string choice = ReadLine();
            if (choice == "1")
            {
                Friend = Friends.Encounter();
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

            WriteLine("You ran for what seems like hours till you see the Mothership hovering above a mountain. You now know your destination and mush find a way to get there");
            WriteLine();
            WriteLine("You walk towards the mountain, thinking you're getting closer when suddenly you are at the entrance of the cave" +
                "\nYou here a faint bang of a pickaxe, there might be a miner in here somewhere (or it's a recording from that little shack that some miner looking person is sleeping in...)");
            WriteLine();
            WriteLine("On the brightside, the shack as a sign saying \"If you are looking for Mt. Omega, just go straght down this cave, it's at the end.\" Oh, how conviniant! Guess they don't want to be bothered...");
            WriteLine();
            WriteLine("Given the new layout you have, 3 options! Choose wisely... " +
                "\n(or don't, I'm not a cop)");
            WriteLine();
            WriteLine("1) Continue down the cave and hope for the best" +
                "\n2) Test you \"sweet\" break dancing skills" +
                "\n3) Talk to that miner... (be causious they kinda smell...)");

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
                WriteLine("Wow... Great moves genius, you get impailed by stalagmite... who practices break dances in a cave! ");
                ReadKey();
                Game.GameOver();
            }
        }

        public static void Mountain()
        {
            Clear();
            WriteLine("You've made it to the end of the cave, and thankfully not covered in spiders! (wait, there was spiders?)");
            WriteLine();
            WriteLine("Well nevermind that, You're now at the base of Mt. Omega! But a few issues are at hand...");
            WriteLine();
            WriteLine("How are you going to get up? Are you going to climb?! (Ain't nobody got time for that!)" +
                "\nLucky for you you can \"Prove your worth and climb this mountain\" or live with that lumberjack that's chopping wood next to that shack with a \"vacancy open\" sign... what's your choice?");
            WriteLine();
            WriteLine("1) Hardcore Parkour our way up" +
                "\n2) Climb the mountain to reach the top" +
                "\n3) Give up and live in a shack (with that lumberjack that has been chopping wood all this time)");

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

            if (Friends.HasFriend == true)
            {
                WriteLine("But do you want to... all your friends climbed up with you and has been by your side! \n do you really want to leave them?" +
                    "\n 1)Yes" +
                    "\n 2)No");
                string choice = ReadLine();
                if (choice == "1")
                {
                    Game.Congrats();
                }
                else if(choice == "2")
                {
                    Game.HappyEverAfter();
                }
            }
            else
            {
                Game.Congrats();
            }
        }
    }
}
