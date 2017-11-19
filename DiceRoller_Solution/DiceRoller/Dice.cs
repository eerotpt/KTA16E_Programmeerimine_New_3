using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        public int Sides { get; }
        public string Description { get; }
        private Random Random { get; } = new Random();

        private Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(6, "d8");

        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1);
        }
    }
}
