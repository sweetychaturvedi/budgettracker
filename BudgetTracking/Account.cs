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
        #region properties
        /// <summary>
        /// 
        /// </summary>
        public TypeOfAccounts AccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        private List<Transaction> Transactions { get; set; }
        
        #endregion
        
        public Account()
        {
            this.Transactions = new List<Transaction>();
        }

        #region Public Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        public void AddIncome(decimal income)
        {
            this.Balance = this.Balance + income;

            var transaction = new Income()
            {
                Amount = income,
                TransactionDate = DateTime.UtcNow
            };

            this.Transactions.Add(transaction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="category"></param>
        /// <param name="ammount"></param>
        public void AddExpenses(string item, string category, decimal ammount)
        {
            this.Balance = this.Balance - ammount;

            var transaction = new Expense();
            transaction.Amount = -ammount;
            transaction.TransactionDate = DateTime.UtcNow;
            transaction.Category = category;
            transaction.Item = item;

            this.Transactions.Add(transaction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetTransactions()
        {
            return this.Transactions;
        }        
        
        #endregion
    }
}
