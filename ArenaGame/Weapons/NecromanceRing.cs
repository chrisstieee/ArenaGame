using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class NecromanceRing : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public NecromanceRing(string name)
        {
            Name = name;
            AttackDamage = 10 + CallForTheDead();
            BlockingPower = 12;
        }

        private double CallForTheDead()
        {
            Random random = new Random();
            double multiplier = 0;
            if (random.NextDouble() < 0.2)
            {
                multiplier = 20;
            }
            return multiplier;
        }
    }
}
