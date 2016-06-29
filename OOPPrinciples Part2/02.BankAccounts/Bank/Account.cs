namespace _02.BankAccounts.Bank
{
    public class Account : IAccount
    {
        public Account (CustomerType customer, int interestRate, int balanceRate, int months)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.BalanceRate = balanceRate;
            this.Months = months;
        }

        public CustomerType Customer{ get; set; }

        public int InterestRate { get; set; }

        public int BalanceRate { get; set; }

        public int Months { get; set; }

        public int Money { get; set;  }

        public virtual int Calculate(int interestRate, int months)
        {
            return interestRate * months;
        }
    }
}
