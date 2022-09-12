using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject gObject;//value is null
            gObject = new GameObject();//create an instance of GameObject

            gObject.X = 30;//calls the setter
            int xPos = gObject.X; //calls the getter

            GameObject player = new GameObject(5, 10, ConsoleColor.Yellow);

            gObject.Render();
            player.Render();
            GameObject.Info();

            Console.ReadKey();
        }
    }
}
