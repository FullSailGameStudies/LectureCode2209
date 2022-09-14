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
            gObject = Factory.BuildGameObject(0,0,ConsoleColor.Green);//create an instance of GameObject

            gObject.X = 30;//calls the setter
            int xPos = gObject.X; //calls the getter

            Player player = Factory.BuildPlayer(2, 5, 10, ConsoleColor.Yellow);

            //Console.ReadKey();

            gObject.Render();
            player.Render();
            GameObject.Info();

            Inventory backpack = new Inventory(3, new List<string>() { "sword" });
            try
            {
                backpack.AddItem("map");
                backpack.AddItem("pickaxe");
                backpack.AddItem("pipe bomb");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 100000, 1000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} damage to the rat!");


            #region Casting
            int num = 5;
            long bigNum = num;//IMPLICIT casting

            num = (int)bigNum;//EXPLICIT casting

            //player is a Player type. Player is-a GameObject
            //gObject is a GameObject type.

            //UPCASTING
            //  casting from a DERIVED type (Player) to a BASE type (GameObject)
            //  ALWAYS safe!
            GameObject gObj2 = player;
            #endregion

            Console.ReadKey();
        }
    }
}
