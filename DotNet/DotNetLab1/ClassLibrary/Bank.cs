namespace ClassLibrary;

public class Bank
{
    public string Name { get; set; }
    private List<AutomatedTellerMachine> AtMs { get; set; }
    private List<Account> Accounts { get; set; }

    public Bank(string name)
    {
        Name = name;
        AtMs = [];
        Accounts = [];
    }

    public Account GetAccount(string cardNumber)
    {
        return Accounts.FirstOrDefault(a => a.CardNumber == cardNumber) ?? throw new InvalidOperationException();
    }

    public AutomatedTellerMachine GetAtm(string atmId)
    {
        return AtMs.FirstOrDefault(atm => atm.ATMId == atmId) ?? throw new InvalidOperationException();
    }

    public void AddAtm(AutomatedTellerMachine atm)
    {
        AtMs.Add(atm);
    }

    public void AddAccount(Account account)
    {
        if (Accounts.Any(a => a.CardNumber == account.CardNumber))
        {
            throw new InvalidOperationException("Обліковий запис з таким номером картки вже існує.");
        }
        Accounts.Add(account);
    }

    public void TransferFunds(string fromCardNumber, string toCardNumber, decimal amount)
    {
        var fromAccount = GetAccount(fromCardNumber);
        var toAccount = GetAccount(toCardNumber);

        if (fromAccount == null || toAccount == null)
        {
            throw new InvalidOperationException("Один з рахунків не знайдено.");
        }

        fromAccount.Transfer(toAccount, amount);
    }
}
