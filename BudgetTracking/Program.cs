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
            Console.WriteLine("welcome to The Budget Tracking");
            Console.WriteLine("1 Add account");
            Console.WriteLine("2 Add income");
            Console.WriteLine("3 Add Expenses");
            Console.WriteLine("4 Show Baance");
            Console.WriteLine("5 Show Transaction");
            Console.WriteLine("press v to exit");

            Console.WriteLine("choice");
            var option = Console.ReadLine();
            Account account = null;
            while (option != "v")
            {
                switch (option)
                {
                    case "1":

                        // Add Account

                        Console.WriteLine("enter account name");
                        string accountName = Console.ReadLine();

                        Console.WriteLine("choose account type");
                        Console.WriteLine("1. Checkings");
                        Console.WriteLine("2. Savings");
                        string accountType = Console.ReadLine();

                        TypeOfAccounts types;
                        if (accountType == "1")
                        {
                            types = TypeOfAccounts.Checkings;
                        }
                        else
                        {
                            types = TypeOfAccounts.Savings;
                        }
                        account = AccountManager.AddAccount(accountName, types);
                        Console.WriteLine("account added.");

                        break;

                    case "2":
                        //Addincome
                        Console.WriteLine("Enter your income");
                        string data = Console.ReadLine();
                        account.AddIncome(decimal.Parse(data));
                        break;

                    case "3":
                        //addexpenses
                        Console.WriteLine("Enter your ammount");
                        string ammount = Console.ReadLine();

                        Console.WriteLine("Enter the item name");
                        string item = Console.ReadLine();

                        Console.WriteLine("Enter your cateogary");
                        string category = Console.ReadLine();

                        account.AddExpenses(item, category, decimal.Parse(ammount));
                        break;

                    case "5":
                        //veiw transaction
                        var list = account.GetTransactions();
                        foreach (var a in list)
                        {
                            if (a is Income)
                            {
                                Console.WriteLine($"{a.TransactionDate} income income { a.Amount} ");
                            }
                            else
                            {
                                Console.WriteLine($"{((Expense)a).TransactionDate} {((Expense)a).Item} {((Expense)a).Category}");
                            }
                        }
                        break;

                    case "4":
                        //show balance
                        Console.WriteLine(account.Balance);

                        break;
                    default:

                        Console.WriteLine("invalid choice");
                        break;
                }

                Console.Write("choice: ");
                option = Console.ReadLine();
            }



        }

    }
}