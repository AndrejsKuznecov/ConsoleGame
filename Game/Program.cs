using System;
using System.Linq;

namespace Game
{
    class Program
    {
        static bool inputCheck(string input, string inputType)
        {
            switch (inputType)
            {
                case ("str"):
                    if (input.All(Char.IsLetter) && input.Length>0)
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! you must input string");
                    break;

                case ("chr"):
                    if (input.All(Char.IsLetter) && input.Length == 1)
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! you must input character");
                    break;

                case ("int"):
                    if (input.All(Char.IsDigit) && input.Length > 0 )
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! You must input number");
                    break;

                default:
                    break;
            }
            return false;
        }

        static void Main(string[] args)
        {
            bool gameRunning = true;
          while (gameRunning)
            {
                string input;
                Console.WriteLine("Weclome, choose an options (enter value). \n 1. Choose theme \n 2.Rules \n 0.Exit");

                input = Console.ReadLine().Trim();
                while (!inputCheck(input, "int"))
                {
                    Console.WriteLine("Please enter proper type.");
                    input = Console.ReadLine();
                }

                
                switch (int.Parse(input))
                {
                    case 1:
                        //ThemeSelector();
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
