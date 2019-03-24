using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
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
            int sumList = list.Sum();
            Console.WriteLine(sumList);
            Console.ReadLine();
        }
    }
}

