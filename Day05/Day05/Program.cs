using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 13, 5, 3, 52 };
            Swap(numbers, 1, 2);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            DoIt(0);
            Console.ResetColor();

            ulong result = Factorial(5);
            Console.WriteLine($"5! = {result}");

        }

        private static void Swap(int[] numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }

        static void DoIt(int i)
        {
            if (i < 100)//exit condition
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(i);

                DoIt(i + 1);//i++

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
        }

        static ulong Factorial(uint N)
        {
            if (N > 1)
            {
                ulong result = N * Factorial(N - 1);
                return result;
            }
            return 1;
        }
    }
}
