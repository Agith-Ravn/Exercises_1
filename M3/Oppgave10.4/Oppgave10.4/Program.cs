using System;

namespace Oppgave10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Agith", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} kr.");

            account.MakeWithdrawal(500, DateTime.Now, "Drivstoff");
            Console.WriteLine(account.Balance);
        }
    }
}
