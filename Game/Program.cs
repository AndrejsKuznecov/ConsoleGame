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
                string input;
                Console.WriteLine("Weclome, choose an options (enter value). \n 1. Choose theme \n 2.Rules \n 0.Exit");

                input = Console.ReadLine().Trim();
                while (!InputCheck.inputCheck(input, "int"))
                {
                    Console.WriteLine("Please enter proper type.");
                    input = Console.ReadLine();
                }

                
                switch (int.Parse(input))
                {
                    case 1:
                        Dictionary<string,string> selectedTheme =  ThemeSelector.SelectedTheme();
                        Questions.Start(selectedTheme);
                        //foreach(var k in selectedTheme)
                        //{
                        //    Console.WriteLine(k.Key);
                        //}
                        break;
                    case 2:
                        Console.WriteLine("Rules");
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
