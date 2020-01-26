using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    public static class AccountManager
    {
        public static Account AddAccount(string accountName, TypeOfAccounts accountType)
        {
            var account = new Account()
            {
                AccountName = accountName,
                AccountType = accountType
            };
            return account;
        }

    }
}
