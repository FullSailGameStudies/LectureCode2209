using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create an instance of the GameObject class
            GameObject g2 = new GameObject(10, 15, ConsoleColor.DarkCyan);
            //2. call any non-static method on the variable
            g2.Render();

            GameObject gObject;//value is null
            gObject = Factory.BuildGameObject(0, 0, ConsoleColor.Green);//create an instance of GameObject

            gObject.X = 30;//calls the setter
            int xPos = gObject.X; //calls the getter

            Player player = Factory.BuildPlayer('$',2, 5, 10, ConsoleColor.Yellow);

            //Console.ReadKey();

            gObject.Render();
            player.Render();
            GameObject.Info();

            Inventory backpack = new Inventory(3, new List<FantasyWeapon>());
            //try
            //{
            //    backpack.AddItem("map");
            //    backpack.AddItem("pickaxe");
            //    backpack.AddItem("pipe bomb");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 100000, 1000);
            int damage = sting.DoDamage(200);
            Console.WriteLine($"We swing sting and do {damage} damage to the rat!");

            backpack.AddItem(sting);
            //UPCASTS BowWeapon instance to a FantasyWeapon
            backpack.AddItem(new BowWeapon(5, 10, WeaponRarity.Common, 1, 10, 20));

            List<BowWeapon> myBows = backpack.Bows();

            backpack.Items.Print();

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

            //DOWNCASTING
            //  casting from a BASE type (GameObject) to a Derived type (Player)
            //  NOT safe!!!!
            gObj2 = new GameObject(10, 10, ConsoleColor.Magenta);
            //1) try-catch with an explicit cast
            try
            {
                Player playerTwo = (Player)gObj2;//throw an exception at runtime
            }
            catch (Exception)
            {
            }

            //2) use the 'as' keyword to cast
            //will assign null to p2 IF gObj2 is NOT a player object
            Player p2 = gObj2 as Player;//will NOT throw an exception
            if (p2 != null)
                p2.Render();//null-reference exception

            //3) use pattern matching with the 'is' keyword
            if (gObj2 is Player p3)
                p3.Render();

            backpack.PrintInventory();
            #endregion

            Console.ReadKey();
            List<IGameObject> gameObjs = new List<IGameObject>();
            for (int i = 0; i < 20; i++)
            {
                int x = randy.Next(Console.WindowWidth);
                int y = randy.Next(Console.WindowHeight);
                ConsoleColor color = GetRandomColor();
                gameObjs.Add(Factory.BuildGameObject(x, y, color));
            }
            for (int i = 0; i < 5; i++)
            {
                gameObjs.Add(new Seeker(player));
            }
            gameObjs.Add(player);
            Console.Clear();
            Console.CursorVisible = false;
            Render(gameObjs);
            while (true)
            {
                //update the game objects
                if (!player.Update())
                    break;


                Render(gameObjs);

                if (Collision(player, gameObjs))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("BOOM!!!");
                    Console.ResetColor();
                    break;
                }
            }
            Console.CursorVisible = true;

            foreach (WeaponRarity rarity in Enum.GetValues<WeaponRarity>())
            {

            }

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            nums.Print();
            List<string> names = new List<string>() { "Bruce", "Batman", "The Bat" };
            names.Print();

            Console.ReadKey();
        }

        private static void Render(List<IGameObject> gameObjs)
        {
            //render the game objects
            //gObject.Render();
            //player.Render();
            foreach (IGameObject obj in gameObjs)
                obj.Render();
        }

        static Random randy = new Random();
        private static ConsoleColor GetRandomColor()
        {
            ConsoleColor color = ConsoleColor.Gray;

            while ((color = (ConsoleColor)randy.Next(16)) == ConsoleColor.Black) ;

            return color;
        }

        private static bool Collision(Player player, List<IGameObject> gameObjs)
        {
            bool collision = false;
            foreach (var gameObject in gameObjs)
            {
                if (player != gameObject && player.X == gameObject.X && player.Y == gameObject.Y)
                {
                    collision = true;
                    break;
                }

            }
            return collision;
        }
    }
}
