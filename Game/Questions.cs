using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game
{
    class Questions
    {
        public static void Start(Dictionary<string, string> dictionary)
        {
            Random r = new Random();
            int vordsDict = dictionary.Count;
            int rand = r.Next(0, vordsDict);
            string word = dictionary.ElementAt(rand).Key;
            string wordDescription = dictionary.ElementAt(rand).Value;
            List<char> charList = word.ToList();
            int hintCount = word.Length / 2;
            bool guessing = true;

            while (guessing) {
                if (hintCount > 0)
                {
                    Console.WriteLine("Hints left:" + hintCount + "\n");
                    Console.WriteLine("Choose an option(to guess the word or a hint): \n 1. Guess the word \n 2.Hint: To get first letter of the word \n 3.Hint: To get word length \n 4.Hint: To get if a certain letter contains in the word. \n 5.Hint: Get small description about the word.  \n 6.Hint: ");
                    string input = Console.ReadLine().Trim();
                    while (!InputCheck.inputCheck(input, "int"))
                    {
                        Console.WriteLine("Please enter proper type.");
                        input = Console.ReadLine().Trim();
                    }
                    switch (int.Parse(input))
                    {
                        case 1:
                            guessing = false;
                            Console.WriteLine("Guess the word:");
                            input = Console.ReadLine().Trim();
                            while (!InputCheck.inputCheck(input, "str"))
                            {
                                Console.WriteLine("Please enter proper type.");
                                input = Console.ReadLine().Trim();
                            }
                            if (wordGuessing(input, word))
                            {
                                Console.WriteLine("You Won!!");
                            }
                            else
                                Console.WriteLine("You Lost!!");
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("First letter of the word: " + charList.First());
                            hintCount -= 1;
                            break;
                        case 3:
                            Console.WriteLine("Word length" + word.Length);
                            hintCount -= 1;
                            break;
                        case 4:
                            Console.WriteLine("Enter a letter:");
                            input = Console.ReadLine().Trim();
                            while (!InputCheck.inputCheck(input, "chr"))
                            {
                                Console.WriteLine("Please enter proper type.");
                                input = Console.ReadLine().Trim();
                            }
                            char inputChar = input[0];
                            checkLetter(charList,inputChar);
                            hintCount -= 1;
                            break;
                        case 5:
                            Console.WriteLine(wordDescription);
                            break;
                        case 6:
                            break;

                        default:
                            Console.WriteLine("Chose an option");
                            break;
                    }
                }
                else {
                    Console.WriteLine("You have to guess");
                    guessing = false;
                    Console.WriteLine("Guess the word:");
                    string input = Console.ReadLine().Trim();
                    while (!InputCheck.inputCheck(input, "str"))
                    {
                        Console.WriteLine("Please enter proper type.");
                        input = Console.ReadLine().Trim();
                    }
                    if (wordGuessing(input, word))
                    {
                        Console.WriteLine("You Won!!");
                    }
                    else
                        Console.WriteLine("You Lost!!");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();


                }
            }
            Console.WriteLine("\nWord was:" + word);

        }
        private static bool wordGuessing(string guess,string word)
        {
            if ((string.Compare(guess.ToLower(), word.ToLower()) == 0))
            {
                return true;
            }

            return false;
        }
        private static void checkLetter(List<char> word, char input)
        {
            var result = word.Where(s => s==input);
            Console.WriteLine("Letter contains: " + result.Count() + " times");

        }
    }
}
