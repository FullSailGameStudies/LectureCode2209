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
            PrintMessage(message);
        }
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }
        static void PrintMessage(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
        }

        static string GetMessage()
        {
            Console.Write("Please enter a message: ");
            string msg = Console.ReadLine();
            return msg;
        }
    }
}
