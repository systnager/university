using ClassLibrary;

class Program
{
    static Bank bank = new("Mono");

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        InitializeTestData();
        Console.WriteLine("Ласкаво просимо до банкомату!");

        while (true)
        {
            Console.Write("Введіть номер картки: ");
            var cardNumber = Console.ReadLine();

            Console.Write("Введіть PIN-код: ");
            var pinCode = Console.ReadLine();

            if (cardNumber == null) continue;
            var account = bank.GetAccount(cardNumber);
            
            if (pinCode != null && account.Authenticate(cardNumber, pinCode))
            {
                ShowMenu(account);
            }
            else
            {
                Console.WriteLine("Невірний номер картки або PIN-код.");
            }
        }
    }

    private static void ShowMenu(Account account)
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Переглянути баланс");
            Console.WriteLine("2. Зняти кошти");
            Console.WriteLine("3. Зарахувати кошти");
            Console.WriteLine("4. Переказати кошти на іншу картку");
            Console.WriteLine("5. Вихід");

            Console.Write("Оберіть дію: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewBalance(account);
                    break;
                case "2":
                    Withdraw(account);
                    break;
                case "3":
                    Deposit(account);
                    break;
                case "4":
                    Transfer(account);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    private static void ViewBalance(Account account)
    {
        Console.WriteLine($"Ваш баланс: {account.Balance} грн.");
    }

    private static void Withdraw(Account account)
    {
        Console.Write("Введіть суму для зняття: ");
        if (decimal.TryParse(Console.ReadLine(), out var amount))
        {
            try
            {
                account.OnWithdraw += Console.WriteLine;
                bank.GetAtm("ATM1").ProcessWithdrawal(account, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Невірна сума.");
        }
    }

    private static void Deposit(Account account)
    {
        Console.Write("Введіть суму для зарахування: ");
        if (decimal.TryParse(Console.ReadLine(), out var amount))
        {
            account.OnDeposit += Console.WriteLine;
            bank.GetAtm("ATM1").ProcessDeposit(account, amount);
        }
        else
        {
            Console.WriteLine("Невірна сума.");
        }
    }

    private static void Transfer(Account account)
    {
        Console.Write("Введіть номер картки отримувача: ");
        var recipientCardNumber = Console.ReadLine();

        Console.Write("Введіть суму для переказу: ");
        if (decimal.TryParse(Console.ReadLine(), out var amount))
        {
            try
            {
                if (recipientCardNumber == null) return;
                bank.TransferFunds(account.CardNumber, recipientCardNumber, amount);
                Console.WriteLine($"Переказ {amount} грн. на картку {recipientCardNumber} успішно виконано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Невірна сума.");
        }
    }

    private static void InitializeTestData()
    {
        bank.AddAtm(new AutomatedTellerMachine("ATM1", "Чуднівська 103", 10000m));
        bank.AddAccount(new Account("1111 1111 1111 1122", "Іван Іваненко", "1234", 5000m));
        bank.AddAccount(new Account("4441 1111 1234 5678", "Петро Петренко", "5678", 3000m));
    }
}
