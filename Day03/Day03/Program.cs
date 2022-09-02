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
            Menu["Impossible Burger"] = 9.99F;//will NOT throw. will overwrite the value

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant bigGs = new Restaurant("Big G's Burgers");

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
