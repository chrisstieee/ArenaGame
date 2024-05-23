using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Hunter : Hero
    {
        private int arrowsCount;
        public Hunter(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
            arrowsCount = random.Next(1, 10);
        }
        public override double Attack()
        {
            double damage = base.Attack();
            if (arrowsCount>0)
            {
                damage += 2;
                arrowsCount--;
            }
            return damage;
        }
    }
}
