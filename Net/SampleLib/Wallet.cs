using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{
    public class Wallet
    {
        private decimal balance = 5.1m;

        public decimal IncreaseWallet(decimal input)
        {
            balance += input;
            return balance;
        }

        public decimal DecreaseWallet(decimal input)
        {
            balance -= input;
            return balance;
        }
    }
}
