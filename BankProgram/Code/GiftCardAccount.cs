using System;
using System.Collections.Generic;

namespace bankLibrary
{
    public class GiftCardAccount : BankAccount
    {
        decimal _monthlyDeposit = 0m;
        public GiftCardAccount() { }
        public GiftCardAccount(string owner, string name, decimal initialBalance, decimal mounthlyDeposit = 0m) : base(owner, name, initialBalance)
        {
            _monthlyDeposit = mounthlyDeposit;
        }
        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0m)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}