using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Mage : Hero
    {
        private int mana;
        public Mage(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
            mana = random.Next(1, 6);
        }
        public override double Attack()
        {
            double damage = base.Attack();
            if (mana > 0)
            {
                damage += 3;
                mana--;
            }
            else
            {
                damage -= 6;
                mana = 5;
            }
            return damage;
        }
    }
}
