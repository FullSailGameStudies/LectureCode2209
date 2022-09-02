using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    class Restaurant
    {
        public string Name { get; set; }
        public Dictionary<string, float> Menu;//null

        public Restaurant(string name)
        {
            Name = name;
            //create an instance of the Dictionary

            //RULE: keys must be unique

            //3 ways to add data to a dictionary:
            //1) the initializer
            Menu = new Dictionary<string, float>()
            {
                //{ key, value }
                { "American Burger", 4.99F },
                { "California Burger", 6.99F }
                //{ "California Burger", 7.99F }//will throw an exception
            };

            //2. the Add(key,value) method
            Menu.Add("BBQ Burger", 5.99F);
            //Menu.Add("BBQ Burger", 5.99F);//will throw an exception

            //3. [key] = value
            Menu["Impossible Burger"] = 8.99F;
            Menu["Impossible Burger"] = 12.99F;//will NOT throw. will overwrite the value

        }

        public void Print()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            string title = $"--------{Name} Menu---------";
            int x = Console.WindowWidth / 2 - title.Length / 2;
            int y = Console.WindowHeight / 2 - Menu.Count / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(title);

            foreach (KeyValuePair<string, float> item in Menu)
            {
                //set the horizontal position of the cursor
                Console.CursorLeft = x + 4;

                string menuItem = item.Key;
                float price = item.Value;
                Console.WriteLine($"{price,9:C2} {menuItem}");
            }
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant bigGs = new Restaurant("Big G's Burgers");
            bigGs.Print();
            Console.ReadKey();

            DictionaryChallenge();
        }

        static void DictionaryChallenge()
        {
            Random rando = new Random();
            Dictionary<string, double> pg2 = new Dictionary<string, double>()
            {
                {"Aren",  rando.NextDouble() * 100 }
            };

            pg2.Add("Wolf", rando.NextDouble() * 100);

            pg2["Jon"] = rando.NextDouble() * 100;
            pg2["Devasean"] = rando.NextDouble() * 100;
        }
    }
}
