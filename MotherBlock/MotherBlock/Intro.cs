using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Intro
    {
        public static void IntroOne()
        {
            Clear();
            WriteLine("This is your MotherShip.");
            WriteLine(@"    _ _ _
  /_/_/_/\
 /_/_/_/\/\
/_/_/_/\/\/\
\_\_\_\/\/\/
 \_\_\_\/\/
  \_\_\_\/");
            //add clouds
            WriteLine("You are one of many in this collected unit. Until...");

            WriteLine("(press any key to continue)");
            ReadKey();

            IntroTwo();
        }
        
       public static void IntroTwo()
        {
            Clear();
            WriteLine("You have an unfortunate accident.");
            WriteLine(@"
       ^  ^   ^  ^  ^  ^   ^      ___I__      ^  ^   ^  ^  ^   ^  ^
      /|\/|\ /|\/|\/|\/|\ /|\    /\-_-- \    /|\/|\ /|\/|\/|\ /|\/|\
      /|\/|\ /|\/|\/|\/|\ /|\   /  \_ -__\   /|\/|\ /|\/|\/|\ /|\/|\
      /|\/|\ /|\/|\/|\/|\ /|\   |[] | [] |   /|\/|\ /|\/|\/|\ /|\/|\"); 
            WriteLine("You fall to, what seems to be, your death ");

            WriteLine("(Press any key to continue)");
            ReadKey();

            IntroThree();
            //ascii forest art: https://ascii.co.uk/art/forest
        }
        public static void IntroThree()
        {
            Clear();
            WriteLine("You fall for what seems life forever.");
           // WriteLine(@"");
            WriteLine("Of course before you hit the ground you black out.");

            WriteLine("(press any key to continue)");
            ReadKey();

            Scenes.Wake();
        }
    }
}
