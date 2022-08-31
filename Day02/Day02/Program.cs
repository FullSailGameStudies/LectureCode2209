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
        }
    }
}
