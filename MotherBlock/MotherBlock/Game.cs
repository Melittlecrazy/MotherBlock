using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Game
    {
        public string Title = @" _____ ______   ________  _________  ___  ___  _______   ________  ________  ___       ________  ________  ___  __       
|\   _ \  _   \|\   __  \|\___   ___\\  \|\  \|\  ___ \ |\   __  \|\   __  \|\  \     |\   __  \|\   ____\|\  \|\  \     
\ \  \\\__\ \  \ \  \|\  \|___ \  \_\ \  \\\  \ \   __/|\ \  \|\  \ \  \|\ /\ \  \    \ \  \|\  \ \  \___|\ \  \/  /|_   
 \ \  \\|__| \  \ \  \\\  \   \ \  \ \ \   __  \ \  \_|/_\ \   _  _\ \   __  \ \  \    \ \  \\\  \ \  \    \ \   ___  \  
  \ \  \    \ \  \ \  \\\  \   \ \  \ \ \  \ \  \ \  \_|\ \ \  \\  \\ \  \|\  \ \  \____\ \  \\\  \ \  \____\ \  \\ \  \ 
   \ \__\    \ \__\ \_______\   \ \__\ \ \__\ \__\ \_______\ \__\\ _\\ \_______\ \_______\ \_______\ \_______\ \__\\ \__\
    \|__|     \|__|\|_______|    \|__|  \|__|\|__|\|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__| \|__|
                                                                                                                         ";
        public string Description = "Get back to your mothership!";

        //Ascii art for MotherBlock: http://www.patorjk.com/software/taag/#p=testall&f=Rectangles&t=MotherBlock

        public void Play()
        {
            Intro.IntroOne();
            Write("What is your name: ");
            string playerName = ReadLine();
            Player currentPlayer = new Player(playerName);
            WriteLine("Welcome to " + Title + ", " + currentPlayer.Name + "!");

            ReadKey();

            
        }
    }
}
