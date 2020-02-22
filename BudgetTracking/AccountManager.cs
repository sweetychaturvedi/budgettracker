using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    public static class AccountManager
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<Account> accounts;

        /// <summary>
        /// 
        /// </summary>
        static AccountManager()
        {
            accounts = new List<Account>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="accountType"></param>
        /// <returns></returns>
        public static Account AddAccount(string accountName, TypeOfAccounts accountType)
        {
            var account = new Account()
            {
                AccountName = accountName,
                AccountType = accountType
            };

            accounts.Add(account);
            return account;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool DeleteAccount(Account account)
        {
            return accounts.Remove(account);
        }
    }
}
