using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ThemeSelector
    {
        public static Dictionary<string, string> SelectedTheme()
        {
            Dictionary<string, string> office = new Dictionary<string, string>();
            office.Add("chair", "furniture");
            office.Add("manager", "personal");
            Dictionary<string, string> park = new Dictionary<string, string>();
            park.Add("tree", "It haves leaves");
            park.Add("squirrel", "Its alive");

            Console.WriteLine("Choose a theme (enter value). \n 1. Office \n 2. Park");
            Int32.TryParse(Console.ReadLine().Trim(), out int input);
            switch (input)
            {
                case 1:
                    Console.WriteLine("Selected theme: office");
                    return office;
                case 2:
                    Console.WriteLine("Selected theme: park");
                    return park;
                default:
                    Console.WriteLine("Chose an option");
                    break;
            }
            return null;
        }
    }
}
