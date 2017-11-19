using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Dice d6 = Dice.D6;

            var total = 0;
            for (var i = 0; i < 3; i++)
            {
                var roll = d6.Roll();
                Console.WriteLine($"1{ d6.Description }: { roll }");
                total += roll;
            }

            Dice d8 = Dice.D8;
            for (var i = 0; i < 2; i++)
            {
                var roll = d8.Roll();
                Console.WriteLine($"1{ d8.Description }: { roll }");
                total += roll;
            }
            Console.WriteLine();
            Console.WriteLine($"Roll total: {total}");
            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();

        }
    }
}
