using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionLib
{
    public class WalletManager
    {
        public List<Wallet> wallets = new List<Wallet>();

        public WalletManager()
        {
            wallets.Add(new Wallet(){Name = "Master Wallet", Balance = 5.1m });
        }

        public List<Wallet> GetWallets()
        {
            return wallets;
        }

        public int AddWallet(string name, decimal balance)
        {
            Wallet wallet = new Wallet();
            wallet.Name = name;
            wallet.Balance = balance;
            wallets.Add(wallet);
            return wallets.Count;
        }

        public int RemoveWallet(Wallet wallet)
        {
            wallets.Remove(wallet);
            return wallets.Count;
        }
    }
}
