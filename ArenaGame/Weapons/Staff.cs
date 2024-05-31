using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Staff(string name)
        {
            Name = name;
            AttackDamage = 12;
            BlockingPower = 12;
        }

        public double ExecuteSpecialAbility()
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if (probability < 0.2)
            {
                BlockingPower *= 1.5;
            }
            return AttackDamage;
        }
    }
}
