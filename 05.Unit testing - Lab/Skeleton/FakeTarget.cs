namespace Skeleton
{
    using Contracts;

    public class FakeTarget : ITarget
    {
        public int Health
        {
            get => 0;
        }

        public int Experience { get; }

        public void TakeAttack(int attackPoints)
        {
        }

        public int GiveExperience() => 20;

        public bool IsDead() => true;
    }
}
