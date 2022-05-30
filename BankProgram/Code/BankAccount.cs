using System;
using System.Collections.Generic;

namespace bankLibrary
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Number { get; }
        private readonly decimal _minimumBalance;
        public decimal Balance
        {
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
        public BankAccount() { }
        public BankAccount(string owner, string name, decimal initialBalance) : this(owner, name, initialBalance, 0)
        {

        }
        public BankAccount(string owner, string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = accountNumberSeed++.ToString();
            Owner = owner;
            Name = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        private List<Transaction> allTransactions = new List<Transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            Transaction deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\t\tAmount\tBalance\tNote");
            foreach (Transaction transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToString()}\t{transaction.Amount}\t{balance}\t{transaction.Note}");
            }
            return report.ToString();
        }
        public virtual void PerformMonthEndTransactions()
        {

        }
    }
}