using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FantasyWorld
{
    sealed class Dragon : Character
    {
        public int FlightPower { get; set; }

        public Dragon(string name) : base(name)
        {
            Color = ConsoleColor.Green;
        }

        public override void Move()
        {
            int randomDirection = World.random.Next(0, 2);
            int distance = World.random.Next(-2, 3);
            int dx = 0;
            int dy = 0;

            if (randomDirection == 0) 
            {
                dx = distance;
            }
            else 
            {
                dy = distance;
            }

            if (TargetInWorld(Position.X + dx, Position.Y + dy))
            {
                Position.X = Position.X + dx;
                Position.Y = Position.Y + dy;
            }
        }

        public override void Show()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = Color;
            Console.Write(Name);
        }
    }
}