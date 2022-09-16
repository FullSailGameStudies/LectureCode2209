using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Seeker : IGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        Random random = new Random();
        Player _player;
        public Seeker(Player player)
        {
            _player = player;
            X = random.Next(Console.WindowWidth);
            Y = random.Next(Console.WindowHeight);
        }

        public void Render()
        {
            UpdatePosition();
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = (ConsoleColor)random.Next(16);
            Console.Write(" ");
            Console.ResetColor();
        }

        private void UpdatePosition()
        {
            int way = random.Next(100);
            if(way <= 50)
            {
                if (_player.X < X)
                    X--;
                else
                    X++;
            }
            else
            {
                if (_player.Y < Y)
                    Y--;
                else
                    Y++;
            }
        }
    }
}
