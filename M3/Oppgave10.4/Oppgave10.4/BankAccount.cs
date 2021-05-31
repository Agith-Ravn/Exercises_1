using System;
using System.Collections.Generic;

namespace Oppgave10._4
{
    public class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        //Samme som om vi skulle gjøre det under, men med liste.
        //Transaction allTransactions = new Transaction
        private List<Transaction> allTransactions = new List<Transaction>();

        //Method (constructor) for bankkonto
        //Burde inneholde hvem som bankkonto & penger som er inni konto
        public BankAccount(string name, decimal initialBalance)
        {
            //Du kan bruke this isteden for å skrive:
            //Owner = name osv
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance" );

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        //Method (constructor) for å sette inn penger 
                                //??????
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //??????
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        //Method (constructor) for å ta ut penger
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //??????
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            if (Balance - amount < 0)
            {
                //Stoppe program sier de?
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}