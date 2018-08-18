namespace Skeleton.Tests // 2 tests passed
{
    using NUnit.Framework;
    using Contracts;
    using Moq;

    class HeroTests
    {
        private const string HeroName = "Darth Vader";

        [Test]
        public void HeroShouldGainExperinceWhenKillsATarget()
        {
            ITarget target = new FakeTarget();
            IWeapon weapon = new FakeWeapon();
            Hero hero = new Hero(HeroName, weapon);
            hero.Attack(target);

            Assert.AreEqual(20, hero.Experience, "The hero does not gain experience after killing a target.");
        }

        [Test]
        public void HeroGainExperinceWhenKillsATarget() // mocking
        {
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(20);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero(HeroName, fakeWeapon.Object);
            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(20, hero.Experience, "The hero does not gain experience after killing a target.");
        }
    }
}
