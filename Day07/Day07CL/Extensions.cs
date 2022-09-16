using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static void Print<T>(this List<T> items)
        {
            foreach(T item in items)
                Console.WriteLine(item);
        }

        public static List<BowWeapon> Bows(this Inventory backpack)
        {
            List<BowWeapon> bows = new List<BowWeapon>();
            foreach (FantasyWeapon item in backpack.Items)
            {
                if (item is BowWeapon bow)
                    bows.Add(bow);
            }
            return bows;
        }

        public static ConsoleColor GetColor(this WeaponRarity rarity)
        {
            ConsoleColor color = ConsoleColor.Gray;
            switch (rarity)
            {
                case WeaponRarity.Common:
                    color = ConsoleColor.DarkGray;
                    break;
                case WeaponRarity.Uncommon:
                    color = ConsoleColor.Yellow;
                    break;
                case WeaponRarity.Rare:
                    color = ConsoleColor.Green;
                    break;
                case WeaponRarity.Legendary:
                    color = ConsoleColor.Red;
                    break;
            }
            return color;
        }
    }
}
