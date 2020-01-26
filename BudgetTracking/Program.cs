using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    class Program
    {

        static void Main(string[] args)
        {
            var myAccount = AccountManager.AddAccount("chase", TypeOfAccounts.Savings);
        }

    }
}