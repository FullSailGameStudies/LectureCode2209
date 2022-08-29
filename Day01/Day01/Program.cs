using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = 5, n2 = 2;
            int sum = Add(n1, n2);
            sum = Add(7, 3);
            PrintMessage();

            string message = GetMessage();
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }

        static string GetMessage()
        {
            Console.Write("Please enter a message: ");
            string msg = Console.ReadLine();
            return msg;
        }
    }
}
