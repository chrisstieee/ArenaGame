using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Rogue : Hero
    {
        private double evasionProbability;
        private double backstabProbability;
        private double backstabMultiplier;

        public Rogue(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            evasionProbability = 0.2;
            backstabProbability = 0.25;
            backstabMultiplier = 2.0;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double probability = random.NextDouble();
            if (probability < backstabProbability)
            {
                damage *= backstabMultiplier;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            double probability = random.NextDouble();
            if (probability < evasionProbability)
            {
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
