using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }

        public int Level { get; private set; }

        private int _maxDamage = 0;
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int Cost { get; set; }

        public FantasyWeapon(WeaponRarity rarity, int level, int cost, int maxDamage)
        {
            Rarity = rarity;
            //level = Level;//BACKWARDS! WRONG!
            Level = level;
            Cost = cost;
            MaxDamage = maxDamage;
        }

        //public int DoDamage()
        //{
        //    Random rando = new Random();
        //    return (int)(rando.NextDouble() * MaxDamage);
        //}
        public int DoDamage(int enchantment = 0)
        {
            Random rando = new Random();
            return (int)(rando.NextDouble() * (MaxDamage + enchantment));
        }

        public virtual void Display()
        {
            Console.Write($"I have a level {Level} ");
            Console.ForegroundColor = Rarity.GetColor();
            Console.Write($"{Rarity} weapon");
            Console.ResetColor();
            Console.WriteLine($" that costs {Cost:N0} and can do {MaxDamage:N0} of damage.");
        }
    }
}
