using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Mace : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Mace(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 8;
        }

        public double ExecuteSpecialAbility()
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if (probability < 0.25)
            {
                return AttackDamage * 1.8;
            }
            return AttackDamage;
        }
    }
}
