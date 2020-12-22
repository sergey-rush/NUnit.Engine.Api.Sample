namespace ActionLib
{
    public class Balance
    {
        private decimal balance = 5.1m;

        public decimal IncreaseBalance(decimal input)
        {
            balance += input;
            return balance;
        }

        public decimal DecreaseBalance(decimal input)
        {
            balance -= input;
            return balance;
        }
    }
}