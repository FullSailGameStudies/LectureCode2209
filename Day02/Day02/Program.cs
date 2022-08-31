using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge();

            List<string> superCrew;//null
            superCrew = new List<string>() {"Batman", "Superman" };//creating an instance
            superCrew.Add("Wonder Woman");
            superCrew.Add("Flash");

            ListChallenge();
        }

        private static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(randy.NextDouble() * 100);
            }
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rando.Next();
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //indexer is SUPER fast!
            //KEY: contiguous memory
            // memory address + index * sizeof(type)
            // 0x1000 + 5 * 4
            // 0x1000 + 1000000 * 4
            //PERFORMANCE: O(1) - constant
            // DOES NOT CHANGE as the array gets larger
            Console.WriteLine(numbers[5]);

            //FINDING an item in the array,
            // start at the beginning and look at each item
            //PERFORMANCE: O(N) - linear
            // degrades as the array grows
        }
    }
}
