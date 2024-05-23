using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public Bow(string name)
        {
            Name = name;
            AttackDamage = 13 + FireArrows();
            BlockingPower = 5;
        }
        private double FireArrows()
        {
            Random random = new Random();
            double multiplier = 0;
            if (random.NextDouble() > 0.5)
            {
                multiplier = 5;
            }
            return multiplier;
        }

    }
}
