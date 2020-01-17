using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
  public  class Transaction
    {
        public DateTime CreditDate { get; set; }

        public double Amount { get; set; }

        public int AccountNumber { get; set; }
    }
}
