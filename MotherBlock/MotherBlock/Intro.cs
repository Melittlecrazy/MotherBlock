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
            WriteLine("You are one of many in this collected unit. Until...");

            WriteLine("(press any key to continue)");
            ReadKey();

            IntroTwo();
        }
        
       public static void IntroTwo()
        {
            Clear();
            WriteLine("You have an unfortunate accident.");
            //add ascii art of cube falling or forest landscape 
            WriteLine("You fall to, what seems to be, your death ");

            WriteLine("(Press any key to continue)");
            ReadKey();

            //IntroThree();
        }
        //public static void IntroThree()
        //{
        //    Clear();
        //    WriteLine("This is your MotherShip.");
        //    //add ascii art of giant cube in sky
        //    WriteLine("You are one of many in this collected unit. Until...");

        //    WriteLine("(press any key to continue)");
        //    ReadKey();

        //    IntroFour();
        //}
        //public static void IntroFour()
        //{
        //    Clear();
        //    WriteLine("This is your MotherShip.");
        //    //add ascii art of giant cube in sky
        //    WriteLine("You are one of many in this collected unit. Until...");

        //    WriteLine("(press any key to continue)");
        //    ReadKey();

        //    IntroFive();
        //}
        //public static void IntroFive()
        //{
        //    Clear();
        //    WriteLine("This is your MotherShip.");
        //    //add ascii art of giant cube in sky
        //    WriteLine("You are one of many in this collected unit. Until...");

        //    WriteLine("(press any key to continue)");
        //    ReadKey();

        //    Scenes.Wake();
        //}
    }
}
