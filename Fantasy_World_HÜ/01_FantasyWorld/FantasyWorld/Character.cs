using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyWorld
{
    abstract class Character : IMoveable, IShowable
    {
        public ConsoleColor Color { get; set; }
        public IntegerPosition Position { get; set; }
        public string Name { get; set; }

        public Character(string name)
        {
            this.Name = name;

            Position = new IntegerPosition();
            Position.X = World.random.Next(0, World.WIDTH);
            Position.Y = World.random.Next(0, World.HEIGHT);
        }

        public abstract void Move();
        public abstract void Show();

        public bool TargetInWorld(int x, int y)
        {
            if (x >= 0 && y >= 0
                && x < World.WIDTH && y < World.HEIGHT)
            {
                return true;
            }

            return false;
        }
    }
}