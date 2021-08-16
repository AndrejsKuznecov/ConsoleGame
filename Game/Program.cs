using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        


        static void Main(string[] args)
        {
            bool gameRunning = true;
          while (gameRunning)
            {
                Console.Clear();
                string input;
                Console.WriteLine("Weclome, choose an options (enter value). \n 1. Choose theme \n 2.Rules \n 0.Exit");

                input = Console.ReadLine().Trim();
                while (!InputCheck.inputCheck(input, "int"))
                {
                    Console.WriteLine("Please enter proper type.");
                    input = Console.ReadLine().Trim();
                }

                
                switch (int.Parse(input))
                {
                    case 1:
                        Dictionary<string,string> selectedTheme =  ThemeSelector.SelectedTheme();
                        Questions.Start(selectedTheme);
                        break;
                    case 2:
                        Console.WriteLine("That is a word guessing game, where you can chose words theme. After that you'll have opportunity to guess word(if guessed wrong you lost) or chose one of the hints. Good Luck!! \n Press any key to continue");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Closing program");
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Chose an option");
                            break;
                }

            }
        }
    }
}
