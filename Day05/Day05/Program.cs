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

            Split(numbers.ToList());

            //CompareTo
            //returns these values...
            // -1 means LESS THAN
            //  0 means EQUAL TO
            //  1 means GREATER THAN
            string s1 = "Aquamans", s2 = "Aquaman";
            int compareResult = s2.CompareTo(s1);
            if (compareResult == 0) Console.WriteLine($"{s2} EQUALS {s1}");
            else if(compareResult > 0) Console.WriteLine($"{s2} GREATER THAN {s1}");
            else if (compareResult == -1) Console.WriteLine($"{s2} LESS THAN {s1}");
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

        private static void Split(List<int> m)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = m.Count / 2;
            for (int i = 0; i < m.Count; i++)
            {
                if (i < mid)
                    left.Add(m[i]);
                else
                    right.Add(m[i]);
            }
            Console.WriteLine("------------------LEFT---------------");
            foreach(int number in left)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.WriteLine("------------------RIGHT---------------");
            foreach (int number in right)
                Console.Write($"{number} ");
            Console.WriteLine();
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
