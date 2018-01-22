//  Filename: Program.cs
//  Description: Console application to convert a pokemons stats
//  Author: Steven Green
//  Date: 8/20/2016
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatsConverter
{
    class Program
    {
               
        //Main Program
        static void Main(string[] args)
        {
            string pokeName = "Invalid data entry.";
            double pokeHeight = 0;
            double pokeWeight = 0;
            string pokeHeightClass = "Invalid data entry.";
            string pokeWeightClass = "Invalid data entry.";

            Console.WriteLine("Welcome to the Pokemon Stats Converter.");
            Console.WriteLine("Here you can enter your Pokemons name hight and weight, \nand have them Americanized for you.");
            spacer();
                  
            Console.Write("Please Enter your Pokemons name (-1 for Debug):");
            pokeName = Console.ReadLine();

            if (pokeName != "-1")
            {
                Console.Write("Please Enter your Pokemons weight(in kilograms):");
                pokeWeight = double.Parse(Console.ReadLine());
                Console.Write("Please Enter your Pokemons height(in meters:");
                pokeHeight = double.Parse(Console.ReadLine());
            }
            else
            {
                pokeName = args[0];
                pokeHeight = Double.Parse(args[1]);
                pokeWeight = Double.Parse(args[2]);
            }
            spacer();
            Console.WriteLine("\nThe Pokemons name is: " + pokeName);
            Console.WriteLine("The Pokemons weight is: " + pokeWeight + "kg");
            Console.WriteLine("The Pokemons hight is: " + pokeHeight + "m");
            spacer();
            //Calculations and conversions
            pokeWeight *= 35.274;
            pokeWeight = Math.Round(pokeWeight, 2);
            pokeHeight *= 39.3701;
            pokeHeight = Math.Round(pokeHeight, 2);

            //Height Assignment
            pokeHeightClass = getHeightClass(pokeHeight);
            //Weight Assignment
            pokeWeightClass = getWeightClass(pokeWeight);

            Console.WriteLine("CALCULATING PLEASE WAIT");
            spacer();
            //time to print out
            Console.WriteLine("\nThe Pokemons name is: " + pokeName);
            Console.WriteLine("The Pokemons weight is: " + pokeWeight + "oz");
            Console.WriteLine("The Pokemons weight class is: " + pokeWeightClass);
            Console.WriteLine("The Pokemons hight is: " + pokeHeight +  "in");
            Console.WriteLine("The Pokemons hight class is: " + pokeHeightClass);
            
            Console.WriteLine("\nPress Enter to continue.");
            Console.ReadLine();
        }

        /// Spacer Function Used to make code more legible    
        static void spacer()
        {
            for (int z = 1; z < 35; z++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }

        public static String getHeightClass(double pokeHeight)
        {
            string getHeightClass = "Invalid data entry.";

            if (pokeHeight >= 50)
            {
                getHeightClass = "Tall";
            }
            else if (pokeHeight >= 30 && pokeHeight >= 49)
            {
                getHeightClass = "Normal";
            }

            else if (pokeHeight < 30 && pokeHeight > 0)
            {
                getHeightClass = "Short";
            }
            else
            {
                Console.WriteLine("ERROR INVALID DATA CHECK HIGHT INFORMATION");
            }
            return getHeightClass;
        }

        public static String getWeightClass(double pokeWeight)
        {
            string pokeWeightClass = "Invalid data entry.";

            if (pokeWeight >= 500)
            {
                pokeWeightClass = "Extra Large";
            }
            else if (pokeWeight >= 100 && pokeWeight <= 499)
            {
                pokeWeightClass = "Normal";
            }
            else if (pokeWeight < 100 && pokeWeight > 0)
            {
                pokeWeightClass = "Extra Small";
            }
            else
            {
                Console.WriteLine("ERROR INVALID DATA CHECK HIGHT INFORMATION");
            }
            return pokeWeightClass;
        }

    }
}
