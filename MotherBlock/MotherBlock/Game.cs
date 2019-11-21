using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MotherBlock
{
    class Game
    {
        public static string Title = @" _____ ______   ________  _________  ___  ___  _______   ________  ________  ___       ________  ________  ___  __       
|\   _ \  _   \|\   __  \|\___   ___\\  \|\  \|\  ___ \ |\   __  \|\   __  \|\  \     |\   __  \|\   ____\|\  \|\  \     
\ \  \\\__\ \  \ \  \|\  \|___ \  \_\ \  \\\  \ \   __/|\ \  \|\  \ \  \|\ /\ \  \    \ \  \|\  \ \  \___|\ \  \/  /|_   
 \ \  \\|__| \  \ \  \\\  \   \ \  \ \ \   __  \ \  \_|/_\ \   _  _\ \   __  \ \  \    \ \  \\\  \ \  \    \ \   ___  \  
  \ \  \    \ \  \ \  \\\  \   \ \  \ \ \  \ \  \ \  \_|\ \ \  \\  \\ \  \|\  \ \  \____\ \  \\\  \ \  \____\ \  \\ \  \ 
   \ \__\    \ \__\ \_______\   \ \__\ \ \__\ \__\ \_______\ \__\\ _\\ \_______\ \_______\ \_______\ \_______\ \__\\ \__\
    \|__|     \|__|\|_______|    \|__|  \|__|\|__|\|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__| \|__|
                                                                                                                         ";
        public string Description = "Get back to your mothership!";

        //Ascii art for MotherBlock: http://www.patorjk.com/software/taag/#p=testall&f=Rectangles&t=MotherBlock

        public static void Play()
        {
            Clear();
            Intro.IntroOne();
           
        }

        public static void Menu()
        {
            WriteLine(Title);

            WriteLine( "                          1) Start" + "\n                          2)Exit");
            string choice = ReadLine();
            if (choice == "1")
            {
                Play();
            }
            else if (choice == "2")
            {
                ReadKey();
            }
        }

        public static void GameOver()
        {
            Clear();
            WriteLine(@"      ___           ___           ___           ___                    ___                        ___           ___     
     /  /\         /  /\         /__/\         /  /\                  /  /\          ___         /  /\         /  /\    
    /  /:/_       /  /::\       |  |::\       /  /:/_                /  /::\        /__/\       /  /:/_       /  /::\   
   /  /:/ /\     /  /:/\:\      |  |:|:\     /  /:/ /\              /  /:/\:\       \  \:\     /  /:/ /\     /  /:/\:\  
  /  /:/_/::\   /  /:/~/::\   __|__|:|\:\   /  /:/ /:/_            /  /:/  \:\       \  \:\   /  /:/ /:/_   /  /:/~/:/  
 /__/:/__\/\:\ /__/:/ /:/\:\ /__/::::| \:\ /__/:/ /:/ /\          /__/:/ \__\:\  ___  \__\:\ /__/:/ /:/ /\ /__/:/ /:/___
 \  \:\ /~~/:/ \  \:\/:/__\/ \  \:\~~\__\/ \  \:\/:/ /:/          \  \:\ /  /:/ /__/\ |  |:| \  \:\/:/ /:/ \  \:\/:::::/
  \  \:\  /:/   \  \::/       \  \:\        \  \::/ /:/            \  \:\  /:/  \  \:\|  |:|  \  \::/ /:/   \  \::/~~~~ 
   \  \:\/:/     \  \:\        \  \:\        \  \:\/:/              \  \:\/:/    \  \:\__|:|   \  \:\/:/     \  \:\     
    \  \::/       \  \:\        \  \:\        \  \::/                \  \::/      \__\::::/     \  \::/       \  \:\    
     \__\/         \__\/         \__\/         \__\/                  \__\/           ~~~~       \__\/         \__\/    ");
            WriteLine("You died.");

            WriteLine("1) Restart \n 2) Quit");
            string choice = ReadLine();
            if (choice == "1")
            {
                Play();
            }
            else if (choice == "2")
            {
                ReadKey();
            }
        }

        public static void Congrats()
        {
            Clear();
            WriteLine(@"   ______                                         _            __          _    _                          
 .' ___  |                                       / |_         [  |        / |_ (_)                         
/ .'   \_|  .--.   _ .--.   .--./) _ .--.  ,--. `| |-'__   _   | |  ,--. `| |-'__   .--.   _ .--.   .--.   
| |       / .'`\ \[ `.-. | / /'`\;[ `/'`\]`'_\ : | | [  | | |  | | `'_\ : | | [  |/ .'`\ \[ `.-. | ( (`\]  
\ `.___.'\| \__. | | | | | \ \._// | |    // | |,| |, | \_/ |, | | // | |,| |, | || \__. | | | | |  `'.'.  
 `.____ .' '.__.' [___||__].',__` [___]   \'-;__/\__/ '.__.'_/[___]\'-;__/\__/[___]'.__.' [___||__][\__) ) 
                          ( ( __))                                                                         ");
            WriteLine();
            WriteLine("You've made it back to you MotherShip!! (but no one realized you were gone...)");
            WriteLine();
            WriteLine("Thanks for playing my game!");
            WriteLine();
            WriteLine("1) PLay again? \n 2) Quit");
            string choice = ReadLine();
            if (choice == "1")
            {
                Play();
            }
            else if (choice == "2")
            {
                ReadKey();
            }
        }
        public static void HappyEverAfter()
        {
            Clear();
            WriteLine(@"     c  c     .-.   \\\  ///   \/   ()_()      (o)__(o)wWw  wWw W  W       (o)__(o)wW  Ww    .-.   \\\  ///  oo_    
     (OO)   c(O_O)c ((O)(O))  (OO)  (O o)    /)(__  __)(O)  (O)(O)(O)    /)(__  __)(O)(O)  c(O_O)c ((O)(O)) /  _)-< 
   ,'.--.) ,'.---.`, | \ || ,'.--.)  |^_\  (o)(O)(  )  / )  ( \  ||    (o)(O)(  )   (..)  ,'.---.`, | \ ||  \__ `.  
  / //_|_\/ /|_|_|\ \||\\||/ /|_|_\  |(_))  //\\  )(  / /    \ \ | \    //\\  )(     ||  / /|_|_|\ \||\\||     `. | 
  | \___  | \_____/ ||| \ || \_.--.  |  /  |(__)|(  ) | \____/ | |  `. |(__)|(  )   _||_ | \_____/ ||| \ |     _| | 
  '.    ) '. `---' .`||  ||'.   \) \ )|\\  /,-. | )/  '. `--' .`(.-.__)/,-. | )/   (_/\_)'. `---' .`||  ||  ,-'   | 
    `-.'    `-...-' (_/  \_) `-.(_.'(/  \)-'   ''(      `-..-'   `-'  -'   ''(             `-...-' (_/  \_)(_..--'  ");
            WriteLine();
            WriteLine("You lived happy with your ");
            Friends.NumOfFriends();
            Write("friends, all cosy in a home that you've called your own! (We'll being snack for the after party!)");
            WriteLine();
            WriteLine("Thanks for playing my game!");
            WriteLine();
            WriteLine("1) PLay again? \n 2) Quit");
            string choice = ReadLine();
            if (choice == "1")
            {
                Play();
            }
            else if (choice == "2")
            {
                ReadKey();
            }
        }
    }
}
