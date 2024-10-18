namespace ClassLibrary;

public class AutomatedTellerMachine
{
    public string ATMId { get; set; }
    public string Location { get; set; }
    public decimal CashAvailable { get; private set; }

    public AutomatedTellerMachine(string atmId, string location, decimal initialCash)
    {
        ATMId = atmId;
        Location = location;
        CashAvailable = initialCash;
    }

    public void ProcessWithdrawal(Account account, decimal amount)
    {
        if (CashAvailable >= amount)
        {
            account.Withdraw(amount);
            CashAvailable -= amount;
        }
        else
        {
            throw new InvalidOperationException("Недостатньо готівки у банкоматі.");
        }
    }

    public void ProcessDeposit(Account account, decimal amount)
    {
        account.Deposit(amount);
        CashAvailable += amount;
    }
}
