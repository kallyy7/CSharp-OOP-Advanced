namespace Skeleton.Tests // 1 tests passed
{
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttackPoints = 10;
        private const int DurabilityPoints = 10;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void Init()
        {
            this.axe = new Axe(AxeAttackPoints, DurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            this.axe = new Axe(AxeAttackPoints, DurabilityPoints);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
    }
}
