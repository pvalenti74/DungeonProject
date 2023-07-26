using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class EnumNotes
    {
        static void Main(string[] args)
        {
            /*
             * Enums (aka Enumerators) are a data type that hold a list of uniquely-named constants. 
             * You cannot create an enum directly through the VS interface. Instead, you create a class and then adapt it. 
             * When defining values for an enum, they MUST be single values with NO SPACES in a COMMA-SEPARATED list. 
             * You can optionally assign numeric values to represent each item in the enum. These serve the same purpose as index numbers, to look up the data. 
             * If you do not assign each item a numeric value, the compiler will be default. It uses 0 based counting.
             * 
             * Example: An enum would be a great structure to hold card suits (Spades, Clubs, Hearts, Diamonds)
             * 
             * Enums are different from the collections we have been learning. In fact, they are not a collection at all. Instead, each enum is its own custom data type. 
             * This custom data type holds the list of constants as one value. 
             */
            ClassicMonster cm = ClassicMonster.Swamp_Thing;
            Console.WriteLine((int)cm + ") " + cm.ToString().Replace('_',' '));
            Console.WriteLine("The whole list\n\n");
            //Because enums are NOT actually collections, we cannot iterate through them directly.
            var monsters = Enum.GetValues<ClassicMonster>();
            foreach (ClassicMonster item in monsters)
            {
                Console.WriteLine((int)item + ") " + item.ToString().Replace('_',' '));
            }
            Console.Write("Select a classic monster from above. ID: ");
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Invalid number. Program terminating...");
                return;//ends the Method.
            }
            ClassicMonster userMonster = (ClassicMonster)index;

            Console.WriteLine("You chose " + userMonster + "!");

            switch (userMonster)
            {
                case ClassicMonster.Frankenstein: 
                    Console.WriteLine("\nHe's barely holding it together.");

                    break;
                case ClassicMonster.Swamp_Thing:
                    Console.WriteLine("\nIt really needs a blow dryer...");
                    break;
                case ClassicMonster.Wolfman:
                    break;
                case ClassicMonster.Vampire:
                    break;
                case ClassicMonster.Dracula:
                    break;
                case ClassicMonster.Blade:
                    break;
                case ClassicMonster.Mothman:
                    break;
                case ClassicMonster.Godzilla:
                    break;
                case ClassicMonster.Bigfoot:
                    break;
                case ClassicMonster.Meg:
                    break;
                case ClassicMonster.Cthulhu:
                    break;
                case ClassicMonster.Beholder:
                    break;
                case ClassicMonster.Rita:
                    break;
                case ClassicMonster.Zombie:
                    break;
                default:
                    break;
            }
        }
    }

    internal enum ClassicMonster
    {
        Frankenstein = 1, //default first item is zero, if we define a value, then all subsequent values start from the custom value.
        Swamp_Thing,
        Wolfman,
        Vampire,
        Dracula,
        Blade,
        Mothman,
        Godzilla,
        Bigfoot,
        Meg,
        Cthulhu,
        Beholder,
        Rita,
        Zombie
    }
}
