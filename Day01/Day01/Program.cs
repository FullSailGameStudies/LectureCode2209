﻿using System;

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

            //pass in the message and have it timestamped
            Timestamp(ref message);//pass by reference
            PrintMessage(message);

            //pass by ref
            int result;// = 0;
            Add(n1, n2, out result);
            Console.WriteLine(result);
            Add(n1, n2, out sum);


            string aNumber = "Steev";
            bool isGood = IntTryParse(aNumber, out int numResult);
            if(isGood)
                Console.WriteLine($"Number: {numResult}");
            else
                Console.WriteLine($"{aNumber} is NOT a number!");

            Console.WriteLine(DateTime.Now);
        }

        static bool IntTryParse(string stringToParse, out int number)
        {
            bool isNumber = false;
            number = 0;
            try
            {
                number = int.Parse(stringToParse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isNumber;
        }

        private static void Timestamp(ref string msg)
        {
            //msg = DateTime.Now + ": " + msg;
            //$ - C# interpolated string
            msg = $"{DateTime.Now}: {msg}";
        }

        static void Add(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
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
