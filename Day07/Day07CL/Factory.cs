using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        //EVERYTHING inside the class MUST be static
        public static GameObject BuildGameObject(int x, int y, ConsoleColor color)
        {
            GameObject gameObject = new GameObject(x, y, color);
            return gameObject;
        }
        public static Player BuildPlayer(char symbol, int level, int x, int y, ConsoleColor color)
        {
            Player player = new(symbol, level, x, y, color);
            return player;
        }

        public static FantasyWeapon MakeWeapon(WeaponRarity rarity, int level, int cost, int maxDamage)
        {
            return new FantasyWeapon(rarity, level, cost, maxDamage);
        }
    }
}
