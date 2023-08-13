namespace SupportBankAD;

public class Bank
{
    public List<Transaction> Transactions { get; }

    public Bank(List<Transaction> transactions)
    {
        this.Transactions = transactions;
    }

    public List<Account> GetAccounts()
    {
        List<Account> accounts = new List<Account>();

        foreach (var transaction in this.Transactions)
        {
            if (!accounts.Any(account => account.Name == transaction.From))
            {
                accounts.Add(new Account(transaction.From));
            }
            if (!accounts.Any(account => account.Name == transaction.To))
            {
                accounts.Add(new Account(transaction.To));
            }

            accounts.First(account => account.Name == transaction.From).Transactions.Add(transaction);
            accounts.First(account => account.Name == transaction.To).Transactions.Add(transaction);
        }
        return accounts;
    }
}