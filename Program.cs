using SupportBankAD;

var parser = new Parser();

var transactionList = parser.ReadTransactions();

var account = new Account("Tim L", transactionList);
account.GetTotalAmountDue();
account.GetTotalAmountOwed();