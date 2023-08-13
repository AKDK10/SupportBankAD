using System.Transactions;

namespace SupportBankAD;

public class Parser
{
    public List<Transaction> ReadTransactions()
    {
        var transactions = new List<Transaction>();
        using (var reader = new StreamReader(@"./Data/Transactions2014.csv"))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var currentLine = reader.ReadLine();
                var values = currentLine.Split(',');
                var transaction = new Transaction(values[0], values[1], values[2], values[3], decimal.Parse(values[4]));
                transactions.Add(transaction);
            }
        }
        return transactions;
    }
}