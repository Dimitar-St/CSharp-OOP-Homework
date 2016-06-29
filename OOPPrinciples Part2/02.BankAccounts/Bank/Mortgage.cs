namespace _02.BankAccounts.Bank
{
    public class Mortgage : Account
    {
        public Mortgage(CustomerType customerType, int interestRate, int balanceRate, int months) 
            : base(customerType, interestRate, balanceRate, months)
        {
        }

        public override int Calculate(int interestRate, int months)
        {
            if (this.Customer == CustomerType.Company)
            {
                if (months <= 12)
                {
                    return (interestRate / 2) * months;
                }

                return base.Calculate(interestRate, months);
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }

                return interestRate * (months - 6);
            }
        }
    }
}
