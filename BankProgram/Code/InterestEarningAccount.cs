using System;
using System.Collections.Generic;

namespace bankLibrary
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount() { }
        public InterestEarningAccount(string owner, string name, decimal initialBalance) : base(owner, name, initialBalance)
        {

        }
        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "Apply monthly interest");
            }
        }
    }
}