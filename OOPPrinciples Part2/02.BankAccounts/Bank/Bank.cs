namespace _02.BankAccounts.Bank
{
    using System.Collections.Generic;

    public class Bank
    {
        public Bank ()
        {
            this.Accounts = new List<Account>();
        }

        public List<Account> Accounts { get; set; }
    }
}
