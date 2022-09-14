using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject
    {
        public int Level { get; set; }
        //Player constructor MUST call a GameObject constructor
        public Player(int level, int x, int y, ConsoleColor color) : base(x, y, color)
        {
            Console.WriteLine("\tPlayer Constructor");
            Level = level;
        }
    }
}
