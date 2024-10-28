namespace ClassLibrary
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; private set; }

        public event Action<string> OnWithdraw;
        public event Action<string> OnDeposit;

        public Account(string cardNumber, string ownerName, string pinCode, decimal initialBalance)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            PinCode = pinCode;
            Balance = initialBalance;
        }

        public bool Authenticate(string cardNumber, string pinCode)
        {
            return CardNumber == cardNumber && PinCode == pinCode;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                OnWithdraw?.Invoke($"З рахунку {CardNumber} знято {amount} грн.");
            }
            else
            {
                throw new InvalidOperationException("Недостатньо коштів на рахунку.");
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            OnDeposit?.Invoke($"На рахунок {CardNumber} зараховано {amount} грн.");
        }

        public void Transfer(Account recipientAccount, decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                recipientAccount.Deposit(amount);
            }
            else
            {
                throw new InvalidOperationException("Недостатньо коштів для переказу.");
            }
        }
    }
}