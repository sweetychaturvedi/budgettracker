using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    public enum TypeOfAccounts
    {
        Checkings,
        Savings
    }
    public class Account
    {
        public TypeOfAccounts AccountType { get; set; }

        public int AccountNumber { get; set; }

        public string AccountName { get; set; }
    }
}
