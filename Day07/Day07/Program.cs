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

            GameObject player = Factory.BuildGameObject(5, 10, ConsoleColor.Yellow);

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

            Console.ReadKey();
        }
    }
}
