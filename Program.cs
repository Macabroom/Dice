﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        public static void Main(string[] args)

        {
            Dice roll = new Dice();
            roll.Dice();

            Console.WriteLine("Do you want to roll again? Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 'Y')
            {
                Dice die = new Dice();
            }
            if (info.KeyChar == 'N')
            {
                Console.WriteLine();
            }
        }
       
        class Dice
        {
            public static void Man(string[] args)

            {
                int number_of_rolls = 0;
                Random rand = new Random();
                int random_int = rand.Next(1, 11);
                Console.WriteLine(random_int);
                number_of_rolls = random_int;
                List<int> list = new List<int>();

                while (number_of_rolls > 0)
                {
                    int dice_number = rand.Next(1, 7);
                    Console.WriteLine(dice_number);
                    list.Add(dice_number);
                    number_of_rolls = number_of_rolls - 1;
                }
                var List = list.Average();
                Console.WriteLine(List);
                Console.ReadLine();





            }
        }
    }
}

    





