namespace _02.BankAccounts.Bank
{
    using System;

    public class Deposit : Account
    {
        public Deposit(CustomerType customerType, int interestRate, int balanceRate, int months)
            : base(customerType, interestRate, balanceRate, months)
        {
        }

        public override int Calculate(int interestRate, int months)
        {
            if (this.BalanceRate <= 1000 && this.BalanceRate > 0)
            {
                return 0;
            } 

            return base.Calculate(interestRate, months);
        }

        public void MakeDeposit(int money)
        {
            this.Money += money;
        }

        public void MakeWithdraw (int money)
        {
            this.Money -= money;
        }

    }
}
