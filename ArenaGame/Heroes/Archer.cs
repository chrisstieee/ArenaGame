namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        public Archer(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double probability = random.NextDouble();
            if (probability < 0.15)
            {
                damage *= 2.5;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}
