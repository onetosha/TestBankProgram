using System;
using System.Collections.Generic;

namespace bankLibrary
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount() { }
        public LineOfCreditAccount(string owner, string name, decimal initialBalance, decimal creditLimit) : base(owner, name, initialBalance, -creditLimit)
        {

        }
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
        protected override Transaction CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn ? new Transaction(-20, DateTime.Now, "Apply overdraft fee") : default;
    }
}