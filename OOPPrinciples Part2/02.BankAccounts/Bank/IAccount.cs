namespace _02.BankAccounts.Bank
{
    public interface IAccount
    {
        CustomerType Customer { get; set; }

        int InterestRate { get; set; }

        int BalanceRate { get; set; }

        int Months { get; set; }

        int Calculate(int interestRate, int months);
    }
}
