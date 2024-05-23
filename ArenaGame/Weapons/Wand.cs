using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Wand : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Wand(string name)
        {
            Name = name;
            AttackDamage = 10 + CastSpell();
            BlockingPower = 2;
        }
        private double CastSpell()
        {
            Random random = new Random();
            int spellNum = random.Next(1, 4);
            double multiplier;
            if (spellNum == 1)
            {
                multiplier = 7;
            }
            else if (spellNum == 2)
            {
                multiplier = 5;
            }
            else
            {
                multiplier = 3;
            }
            return multiplier;
        }


    }
}
