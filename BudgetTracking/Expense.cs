using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    public class Expense : Transaction
    {
        public string Item { get; set; }

        public string Category { get; set; }
    }
}
