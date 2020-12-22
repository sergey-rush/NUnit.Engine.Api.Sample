using NUnit.Framework;

namespace ActionLib.Tests
{
    public class BalanceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncreaseBalanceTest()
        {
            Balance balance = new Balance();
            var result = balance.IncreaseBalance(5.1m);
            Assert.AreEqual(10.2m, result);
        }

        [Test]
        public void DecreaseBalanceTest()
        {
            Balance balance = new Balance();
            var result = balance.DecreaseBalance(5.1m);
            Assert.AreEqual(0, result);
        }
    }
}