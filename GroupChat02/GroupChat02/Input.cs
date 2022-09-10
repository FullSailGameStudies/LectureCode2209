using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat02
{
    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            while(true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int number) && number >= min && number <= max)
                    return number;//valid number
                Console.WriteLine("That is not a valid integer.");
            }
        }

        public static void ReadString(string prompt, ref string value)
        {
            do
            {
                Console.Write(prompt);
                value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value))
                    break;
                Console.WriteLine("That is not a valid string.");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            foreach(string menuOption in options)
                Console.WriteLine(menuOption);

            selection = ReadInteger(prompt, 1, options.Length);
        }
    }
}
