using System.Linq;
using NUnit.Framework;

namespace ActionLib.Tests
{
    public class WalletTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddWalletTest()
        {
            WalletManager walletManager = new WalletManager();
            var result = walletManager.AddWallet("Test Wallet",5.1m);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void GetWalletsTest()
        {
            WalletManager walletManager = new WalletManager();
            var result = walletManager.AddWallet("Test Wallet", 5.1m);
            Assert.AreEqual(2, result);

            var walletList = walletManager.GetWallets();
            CollectionAssert.AllItemsAreUnique(walletList);
        }

        [Test]
        public void RemoveWalletTest()
        {
            WalletManager walletManager = new WalletManager();
            var output = walletManager.AddWallet("Test Wallet", 5.1m);
            Assert.AreEqual(2, output);

            var walletList = walletManager.GetWallets();
            CollectionAssert.AllItemsAreUnique(walletList);

            var wallet = walletList.Last();
            var result = walletManager.RemoveWallet(wallet);
            Assert.AreEqual(1, result);
            CollectionAssert.DoesNotContain(walletList, wallet);
        }
    }
}