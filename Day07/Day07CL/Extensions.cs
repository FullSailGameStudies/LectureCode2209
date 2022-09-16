using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
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
