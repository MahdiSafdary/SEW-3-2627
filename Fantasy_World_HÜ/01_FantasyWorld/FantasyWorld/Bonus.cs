using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyWorld
{
    abstract class Bonus : IShowable
    {
        public IntegerPosition Position { get; set; }
        public int Value { get; set; }

        public Bonus()
        {
            Position = new IntegerPosition();
            Position.X = World.random.Next(0, World.WIDTH);
            Position.Y = World.random.Next(0, World.HEIGHT);
            Value = 1;
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("B");
        }
    }
}