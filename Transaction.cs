using System.Diagnostics.Contracts;

namespace SupportBankAD;

public class Transaction
{
    public string Date { get; }
    public string From { get; }
    public string To { get; }
    public string Narrative { get; }
    public decimal Amount { get; }


    public Transaction(string Date, string From, string To, string Narrative, decimal Amount)
    {
        this.Date = Date;
        this.From = From;
        this.To = To;
        this.Narrative = Narrative;
        this.Amount = Amount;
    }

    public override string ToString()
    {
        return $"Transaction on {Date} from {From} to {To} of {Amount}({Narrative})";
    }

}

