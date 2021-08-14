﻿using System;
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
            Console.WriteLine("Weclome, choose a theme (enter value). \n 1. Office \n 2.Park");
            string input = Console.ReadLine().Trim();
            while (!InputCheck.inputCheck(input, "int"))
            {
                Console.WriteLine("Please enter proper type.");
                input = Console.ReadLine();
            }


            switch (int.Parse(input))
            {
                case 1:
                    return office;
                case 2:
                    return park;
                default:
                    Console.WriteLine("Chose an option");
                    break;
            }
            return null;
        }
        


    }
}