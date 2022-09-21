using System;

namespace Day11CSharp
{
    internal class Program
    {
        enum Superpowers
        {
            Money, Hair, Strength, Speed, FishWhisperer, ShapeShifting
        }
        static void Main(string[] args)
        {
            //System.
            Console.Write("Hello World!\n");
            Console.WriteLine(sizeof(char));

            Superpowers power = Superpowers.Hair;
            PrintPowers(power);
        }

        private static void PrintPowers(Superpowers power)
        {
            switch (power)
            {
                case Superpowers.Money:
                    break;
                case Superpowers.Hair:
                    break;
                case Superpowers.Strength:
                    break;
                case Superpowers.Speed:
                    break;
                case Superpowers.FishWhisperer:
                    break;
                case Superpowers.ShapeShifting:
                    Console.WriteLine(power);
                    break;
                default:
                    break;
            }
        }
    }
}
