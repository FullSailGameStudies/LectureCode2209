using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject //Player is-a GameObject
    {
        int _oldX, _oldY;

        public int Level { get; set; }
        public char Symbol { get; set; }
        //Player constructor MUST call a GameObject constructor
        public Player(char symbol, int level, int x, int y, ConsoleColor color) : base(x, y, color)
        {
            Console.WriteLine("\tPlayer Constructor");
            Symbol = symbol;
            Level = level;
        }

        public void MoveRight()
        {
            SavePosition();
            _x++;
            if (_x >= Console.WindowWidth)
                _x = 0;
        }

        private void SavePosition()
        {
            _oldX = _x;
            _oldY = _y;
        }

        public void MoveLeft()
        {
            SavePosition();
            _x--;
            if (_x < 0)
                _x = Console.WindowWidth-1;
        }
        public void MoveDown()
        {
            SavePosition();
            _y++;
            if (_y >= Console.WindowHeight)
                _y = 0;
        }
        public void MoveUp()
        {
            SavePosition();
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

        public override void Render()
        {
            Console.SetCursorPosition(_oldX, _oldY);
            Console.BackgroundColor = ConsoleColor.Black ;
            Console.Write(" ");
            Console.ResetColor();

            //base.Render();//FULLY OVERRIDE the base version

            Console.SetCursorPosition(_x, _y);
            Console.ForegroundColor = Color;
            Console.Write(Symbol);
            Console.ResetColor();
        }
    }
}
