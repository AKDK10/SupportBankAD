using SupportBankAD;

var parser = new Parser();

var transactionList = parser.ReadTransactions();
var bank = new Bank(transactionList);

foreach (var account in bank.GetAccounts())
{
    account.GetTotalAmountDue();
    account.GetTotalAmountOwed();
}

