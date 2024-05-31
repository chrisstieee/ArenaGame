using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Shield : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Shield(string name)
        {
            Name = name;
            AttackDamage = 0;
            BlockingPower = 20;
        }

        public double ExecuteSpecialAbility()
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if (probability < 0.3)
            {
                BlockingPower *= 2;
            }
            return AttackDamage;
        }
    }
}
