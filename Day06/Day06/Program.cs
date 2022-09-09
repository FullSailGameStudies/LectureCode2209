using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 5, 8, 13, 42 };
            int numberToFind = 42;
            int indexOf = LinearSearch(nums, numberToFind);
            if(indexOf == -1)
                Console.WriteLine($"{numberToFind} was not found!");
            else
                Console.WriteLine($"{numberToFind} was found at index {indexOf}");
        }

        //performance: O(N) - linear where N is the # of items in the list
        private static int LinearSearch(List<int> nums, int numberToFind)
        {
            int index = -1;//-1 means not found

            for (int i = 0; i < nums.Count; i++)
            {
                if(numberToFind == nums[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
