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
            superCrew = new List<string>(10);//creating an instance
            Info(superCrew);//Count:0 Capacity:8
            superCrew.Add("Wonder Woman");
            Info(superCrew);//Count:1 Capacity:8
            superCrew.Add("Flash"); 
            superCrew.Add("Batman");
            superCrew.Add("Superman");
            Info(superCrew);//Count:4 Capacity:8
            superCrew.Add("Green Lantern");//Count:5 Capacity:??
            Info(superCrew);//Count:5 Capacity:8
            superCrew.Add("Aquaman");
            superCrew.Add("Martian Manhunter");
            superCrew.Add("Shazam");//Count:8 Capacity:8
            superCrew.Add("Cyborg");
            superCrew.Add("Green Arrow");
            superCrew.Add("Arsenal");
            Info(superCrew);//Count:11 Capacity:20
            //Console.WriteLine(superCrew[15]);//index-out-of-range

            superCrew.Remove("Aquaman");//Count:10 Capacity:20
            List<string> jl2 = superCrew.ToList();//clone the list
            List<string> jl3 = new List<string>(jl2);//clones the list

            ListChallenge();
        }

        static void Info(List<string> supers)
        {
            //Count: # of items that have been ADDED
            //Capacity: length of the internal array
            Console.WriteLine($"Count: {supers.Count}\tCapacity: {supers.Capacity}");
        }

        private static void ListChallenge()
        {
            Console.ReadKey();
            List<double> grades = new List<double>();
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(randy.NextDouble() * 100);
            }
            PrintGrades(grades);
            int numDropped = DropFailing(grades);
            Console.WriteLine($"Number of students dropped: {numDropped}");
            PrintGrades(grades);

            var curved = CurveGrades(grades);
            PrintGrades(curved);
        }

        static List<double> CurveGrades(List<double> grades)
        {
            List<double> cloned = grades.ToList();

            for (int i = 0; i < cloned.Count; i++)
            {
                //cloned[i] += 5;
                //if (cloned[i] > 100) cloned[i] = 100;

                //ternary operator
                cloned[i] = (cloned[i] > 95) ? 100 : cloned[i] + 5;
            }

            return cloned;
        }

        private static int DropFailing(List<double> grades)
        {
            int numDropped = 0;
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    if (grades[i] < 59.5)
            //    {
            //        numDropped++;
            //        grades.RemoveAt(i);
            //        i--;
            //    }
            //}
            //OR...use a reverse for loop
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    numDropped++;
                    grades.RemoveAt(i);
                }
            }
            return numDropped;
        }

        static void PrintGrades(List<double> course)//pass by value (COPY)
        {
            Console.WriteLine("---------GRADES-----------");
            for (int i = 0; i < course.Count; i++)
            {
                // ,7  means right-align inside of 7 spaces
                // :N2 means number with 2 decimal places
                double grade = course[i];
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{course[i],9:N2}");
                Console.ResetColor();
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

            //ToList method. needs using System.Linq; 
            List<int> nums = numbers.ToList();

            //pass the array to the constructor call
            List<int> nums2 = new List<int>(numbers);

            //copy each item into the list
            List<int> nums3 = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                nums3.Add(numbers[i]);
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
