using System;

namespace ArenaGame.Heroes
{
    public class Druid : Hero
    {
        private double mana;
        private double maxMana;
        private double healManaCost;

        public Druid(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            maxMana = 150;
            mana = maxMana;
            healManaCost = 30;
        }

        public override double Defend(double damage)
        {
            double minimumDamage = 5;
            if (mana >= healManaCost)
            {
                double actualDamage = base.Defend(damage);
                mana -= healManaCost;
                double inflictedDamage = Math.Max(actualDamage - Armor, minimumDamage);
                Health -= inflictedDamage;
                return inflictedDamage;
            }
            else
            {
                Console.WriteLine($"{Name} doesn't have enough mana to heal!");
                double inflictedDamage = Math.Max(damage - Armor, minimumDamage);
                Health -= inflictedDamage;
                return inflictedDamage;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" with mana {Math.Round(mana, 2)}";
        }
    }
}
