using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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


            Menu["Chicken Burger"] = 7.99F;
            Menu["Chicken Nuggets"] = 3.99F;

            Menu["Fries"] = 3.99F;
            Menu["Sweet Potato Fries"] = 5.99F;
            Menu["Loaded Fries"] = 6.99F;
            Menu["Curly Fries"] = 3.99F;

        }

        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
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

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{price,9:C2} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{menuItem}");
            }

            //foreach (var color in Enum.GetValues<ConsoleColor>())
            //{
            //    Console.BackgroundColor = color;
            //    Console.WriteLine($"                   {color}");
            //}
            Console.ResetColor();
        }

        public void DropMenuItem(string menuItem)
        {
            bool wasRemoved = Menu.Remove(menuItem);
            if(wasRemoved)
                Console.WriteLine($"{menuItem} was dropped from the menu.");
            else
                Console.WriteLine($"{menuItem} was not found.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant bigGs = new Restaurant("Big G's Burgers");
            bigGs.Print();
            Console.ReadKey();
            bigGs.DropMenuItem("Chicken Nuggets");
            Console.ReadKey();
            bigGs.DropMenuItem("Chocolate Shake");
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
            pg2["Charlie"] = rando.NextDouble() * 100;

            PrintGrades(pg2);
            DropStudent(pg2);
        }

        static void DropStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Please enter the student to drop: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;
                bool wasDropped = course.Remove(name);
                PrintGrades(course);
                if (wasDropped)
                    Console.WriteLine($"{name} was dropped from the course.");
                else
                    Console.WriteLine($"{name} was not found."); 
            } while (true);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.Clear();
            Console.WriteLine("---------GRADES---------");
            foreach (KeyValuePair<string,double> student in course)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{grade,9:N2}  ");
                Console.ResetColor();
                Console.WriteLine(name);
            }
        }
    }
}
