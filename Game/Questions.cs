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
            Console.WriteLine(" and descript " + wordDescription);
            List<char> charList = word.ToList();
            int hintCount = word.Length/2;
            Console.WriteLine("Choose an option(to guess the word or a hint): \n 1. Guess the word \n 2.Hint: To get first letter of the word \n 3.Hint: To get letter ammount at word \n 4.Hint: To guess if a certain letter contains in the word. \n 5.Hint: ");
            string input = Console.ReadLine().Trim();
            while (!InputCheck.inputCheck(input, "int"))
            {
                Console.WriteLine("Please enter proper type.");
                input = Console.ReadLine();
            }
            bool guessing = true;
            while (guessing){
                Console.WriteLine("Hints left:" + hintCount);
                switch (int.Parse(input))
                {
                    case 1:
                        break;
                        Console.WriteLine("Selected theme: office");
                    case 2:
                        Console.WriteLine("Selected theme: park");
                        break;
                    default:
                        Console.WriteLine("Chose an option");
                        break;
                }
                guessing = false;
            }
            //foreach(char ch in charList)
            //{
            //    Console.WriteLine(ch);
            //}

        }
    }
}
