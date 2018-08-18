namespace Skeleton.Tests // 4 tests passed
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    class DummyTests
    {
        private Dummy dummy;
        private const int DummyHealth = 10;
        private const int DeathDummyHealth = 0;
        private const int DummyExperience = 10;

        [SetUp]
        public void Init()
        {
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void DummyLosesHealtAfterAttack()
        {
            dummy.TakeAttack(3);
            Assert.AreEqual(7, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExIfAttacked()
        {
            this.dummy.Health = DeathDummyHealth;
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
        }

        [Test]
        public void DeadDummyCanGiveXp()
        {
            this.dummy.Health = DeathDummyHealth;
            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]
        public void AliveDummyCantGiveXp()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
