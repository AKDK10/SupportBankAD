using System.Diagnostics.Contracts;

namespace SupportBankAD;

public class Account
{
    public string Name { get; }
    public List<Transaction> Transactions { get; }

    public Account(string name, List<Transaction> transactions)
    {
        this.Name = name;
        this.Transactions = transactions;
    }


    public void GetTotalAmountOwed()
    {
        decimal amountBorrowed = 0;
        foreach (var transaction in this.Transactions)
        {
            if (transaction.To == this.Name)
            {
                amountBorrowed += transaction.Amount;
            }
        }
        Console.WriteLine($"Account name{this.Name} has borrowed £{amountBorrowed}");
    }

    public void GetTotalAmountDue()
    {
        decimal amountLent = 0;
        foreach (var transaction in this.Transactions)
        {
            if (transaction.From == this.Name)
            {
                amountLent += transaction.Amount;
            }
        }
        Console.WriteLine($"Account name{this.Name} has borrowed £{amountLent}");
    }
}
