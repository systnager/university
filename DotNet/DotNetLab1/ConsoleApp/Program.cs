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
            try
            {
                Console.WriteLine("\n1. Увійти в обліковий запис");
                Console.WriteLine("2. Додати нового клієнта");
                Console.Write("Оберіть дію: ");
                var mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        AuthenticateUser();
                        break;
                    case "2":
                        AddNewAccount();
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася несподівана помилка: {ex.Message}");
            }
        }
    }

    private static void AuthenticateUser()
    {
        try
        {
            Console.Write("Введіть номер картки: ");
            var cardNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                Console.WriteLine("Помилка: Номер картки не може бути порожнім.");
                return;
            }

            Console.Write("Введіть PIN-код: ");
            var pinCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(pinCode))
            {
                Console.WriteLine("Помилка: PIN-код не може бути порожнім.");
                return;
            }

            var account = bank.GetAccount(cardNumber);

            if (account.Authenticate(cardNumber, pinCode))
            {
                ShowMenu(account);
            }
            else
            {
                Console.WriteLine("Помилка: Невірний номер картки або PIN-код.");
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Помилка: Обліковий запис з таким номером картки не знайдено.");
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: Сталася помилка під час аутентифікації. Спробуйте ще раз.");
        }
    }

    private static void AddNewAccount()
    {
        try
        {
            Console.Write("Введіть номер картки: ");
            var cardNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                Console.WriteLine("Помилка: Номер картки не може бути порожнім.");
                return;
            }

            Console.Write("Введіть ім'я клієнта: ");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Помилка: Ім'я клієнта не може бути порожнім.");
                return;
            }

            Console.Write("Введіть PIN-код: ");
            var pinCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(pinCode))
            {
                Console.WriteLine("Помилка: PIN-код не може бути порожнім.");
                return;
            }

            Console.Write("Введіть початковий баланс: ");
            if (decimal.TryParse(Console.ReadLine(), out var balance))
            {
                bank.AddAccount(new Account(cardNumber, name, pinCode, balance));
                Console.WriteLine("Новий клієнт успішно доданий.");
            }
            else
            {
                Console.WriteLine("Помилка: Введено некоректну суму для балансу.");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: Сталася помилка під час додавання нового клієнта. Спробуйте ще раз.");
        }
    }
    
    private static void ShowMenu(Account account)
    {
        var exit = false;
        while (!exit)
        {
            try
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
                        Console.WriteLine("Помилка: Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка: Сталася помилка під час виконання операції. Спробуйте ще раз.");
            }
        }
    }

    private static void ViewBalance(Account account)
    {
        Console.WriteLine($"Ваш баланс: {account.Balance} грн.");
    }

    private static void Withdraw(Account account)
    {
        try
        {
            Console.Write("Введіть суму для зняття: ");
            if (decimal.TryParse(Console.ReadLine(), out var amount))
            {
                account.OnWithdraw += Console.WriteLine;
                bank.GetAtm("ATM1").ProcessWithdrawal(account, amount);
            }
            else
            {
                Console.WriteLine("Помилка: Введено некоректну суму.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: Неможливо виконати зняття коштів. Перевірте баланс або спробуйте ще раз.");
        }
    }

    private static void Deposit(Account account)
    {
        try
        {
            Console.Write("Введіть суму для зарахування: ");
            if (decimal.TryParse(Console.ReadLine(), out var amount))
            {
                account.OnDeposit += Console.WriteLine;
                bank.GetAtm("ATM1").ProcessDeposit(account, amount);
            }
            else
            {
                Console.WriteLine("Помилка: Введено некоректну суму.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: Неможливо виконати зарахування. Спробуйте ще раз.");
        }
    }

    private static void Transfer(Account account)
    {
        try
        {
            Console.Write("Введіть номер картки отримувача: ");
            var recipientCardNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(recipientCardNumber))
            {
                Console.WriteLine("Помилка: Номер картки отримувача не може бути порожнім.");
                return;
            }

            Console.Write("Введіть суму для переказу: ");
            if (decimal.TryParse(Console.ReadLine(), out var amount))
            {
                bank.TransferFunds(account.CardNumber, recipientCardNumber, amount);
                Console.WriteLine($"Переказ {amount} грн. на картку {recipientCardNumber} успішно виконано.");
            }
            else
            {
                Console.WriteLine("Помилка: Введено некоректну суму.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: Неможливо виконати переказ коштів. Перевірте дані та спробуйте ще раз.");
        }
    }

    private static void InitializeTestData()
    {
        bank.AddAtm(new AutomatedTellerMachine("ATM1", "Чуднівська 103", 10000m));
        bank.AddAccount(new Account("1111 1111 1111 1122", "Іван Іваненко", "1234", 5000m));
        bank.AddAccount(new Account("4441 1111 1234 5678", "Петро Петренко", "5678", 3000m));
    }
}
