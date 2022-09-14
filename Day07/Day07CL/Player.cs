using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject //Player is-a GameObject
    {
        public int Level { get; set; }
        //Player constructor MUST call a GameObject constructor
        public Player(int level, int x, int y, ConsoleColor color) : base(x, y, color)
        {
            Console.WriteLine("\tPlayer Constructor");
            Level = level;
        }

        public void MoveRight()
        {
            _x++;
            if (_x >= Console.WindowWidth)
                _x = 0;
        }
        public void MoveLeft()
        {
            _x--;
            if (_x < 0)
                _x = Console.WindowWidth-1;
        }
        public void MoveDown()
        {
            _y++;
            if (_y >= Console.WindowHeight)
                _y = 0;
        }
        public void MoveUp()
        {
            _y--;
            if (_y < 0)
                _y = Console.WindowHeight - 1;
        }

        public bool Update()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    return false;
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
            }
            return true;
        }
    }
}
