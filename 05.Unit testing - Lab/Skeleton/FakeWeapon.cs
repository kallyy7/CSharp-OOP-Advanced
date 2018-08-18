namespace Skeleton
{
    using Contracts;

    public class FakeWeapon : IWeapon
    {
        public int AttackPoints
        {
            get => 0;
        }

        public int DurabilityPoints
        {
            get => 0;
        }

        public void Attack(ITarget target)
        {
            target.TakeAttack(this.AttackPoints);
        }
    }
}
