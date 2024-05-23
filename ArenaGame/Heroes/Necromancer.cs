using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Necromancer : Hero
    {
        public Necromancer(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (NotEnoughMagic())
            {
                damage = 0;
            }
            return damage;
        }
        private bool NotEnoughMagic()
        {
            if (random.NextDouble()== 0.1)
            {
                return true;
            }
            return false;
        }
    }
}
