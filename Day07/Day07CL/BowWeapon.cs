using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public int ArrowCount { get; set; }
        public int ArrowCapacity { get; set; }

        public BowWeapon(int arrowCount, int arrowCapacity, WeaponRarity rarity, int level, int cost, int maxDamage) 
            : base(rarity, level, cost, maxDamage)
        {
            ArrowCount = arrowCount;
            ArrowCapacity = arrowCapacity;
        }

        public override void Display()
        {
            base.Display();//EXTEND the base version
            Console.WriteLine($"\tI have {ArrowCount} arrows with a capacity of {ArrowCapacity} arrows");

        }
        public override string ToString()
        {
            return base.ToString() + $"\tI have {ArrowCount} arrows with a capacity of {ArrowCapacity} arrows.";
        }
    }
}
