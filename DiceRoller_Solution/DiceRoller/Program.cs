using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8 });
           
            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();

            //     Dice d6 = Dice.D6;

            // var total = 0;

            // for (var i = 0; i < 3; i++)
            // {
            //     var roll = d6.Roll();
            //     total += roll;
            //     Console.WriteLine($"1{ d6.Description }: { roll }");
            // }

            // Dice d8 = Dice.D8;
            // for (var i = 0; i < 2; i++)
            // {
            //    var roll = d8.Roll();
            //    total += roll;
            //    Console.WriteLine($"1{ d8.Description }: { roll }");
            // }

            //Console.WriteLine();
            //Console.Write("> ");
            //Console.ReadLine();

        }
    }
}
