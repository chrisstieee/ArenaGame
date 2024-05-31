using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Axe(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 5;
        }

        public double ExecuteSpecialAbility()
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if (probability < 0.3)
            {
                return AttackDamage * 1.5;
            }
            return AttackDamage;
        }
    }
}
