using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    public class RecurringExpense : Expense
    {
        public int Frequency { get; set; }
    }
}
