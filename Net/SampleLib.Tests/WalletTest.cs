using NUnit.Framework;

namespace SampleLib.Tests
{
    public class WalletTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IncreaseWalletTest()
        {
            Wallet wallet = new Wallet();
            var result = wallet.IncreaseWallet(5.1m);
            Assert.AreEqual(10.2m, result);
        }

        [Test]
        public void DecreaseWalletTest()
        {
            Wallet wallet = new Wallet();
            var result = wallet.DecreaseWallet(5.1m);
            Assert.AreEqual(0, result);
        }
    }
}