namespace _02.BankAccounts.Bank
{
    using System;

    public class Loan : Account
    {
        public Loan(CustomerType customerType, int interestRate, int balanceRate, int months) 
            : base(customerType, interestRate, balanceRate, months)
        {

        }

        public override int Calculate(int interestRate, int months)
        {
            if (this.Customer == CustomerType.Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                 
                return interestRate * (months - 2);
            }
            else
            {
                if (months <= 3)
                {
                    return 0;
                }

                return interestRate * (months - 3);
            }

        }

        public void MakeDeposit(int moneyYouWantAdd)
        {
            this.Money += moneyYouWantAdd;
        }

        public void MakeWithdraw(int moneyYouWantWithDraw)
        {
            this.Money -= moneyYouWantWithDraw;
        }

    }
}
