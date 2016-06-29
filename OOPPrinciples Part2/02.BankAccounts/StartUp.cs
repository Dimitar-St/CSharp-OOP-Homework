namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Bank;

    public class Startup
    {
        static void Main()
        {
            var doncho = new Loan(CustomerType.Company, 2, 3, 3);

            Console.WriteLine("------------- Doncho ------------");

            Console.WriteLine(doncho.Calculate(doncho.InterestRate, doncho.Months));

            var cuki = new Deposit(CustomerType.Individual, 23, 1001, 101);

            Console.WriteLine("------------- Cuki ------------");

            Console.WriteLine(cuki.Calculate(cuki.InterestRate, cuki.Months));

            var evlogi = new Mortgage(CustomerType.Company, 12, 45, 6);

            Console.WriteLine("------------- Evlogi ------------");

            Console.WriteLine(evlogi.Calculate(evlogi.InterestRate, evlogi.Months));
        }
    }
}
