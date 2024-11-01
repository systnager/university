using System;
using System.Windows.Forms;
using ClassLibrary;

public class ATMForm : Form
{
    private TabControl tabControl;
    private TabPage userTab;
    private TabPage addUserTab;
    
    private TextBox cardNumberTextBox;
    private TextBox pinCodeTextBox;
    private Label balanceLabel;
    private TextBox amountTextBox;
    private TextBox transferCardTextBox;
    
    private TextBox newCardNumberTextBox;
    private TextBox newClientNameTextBox;
    private TextBox newPinCodeTextBox;
    private TextBox newInitialBalanceTextBox;
    
    private Button withdrawButton;
    private Button depositButton;
    private Button transferButton;
    private Button checkBalanceButton;
    private Button loginLogoutButton;
    private Button addNewClientButton;
    
    private Bank bank = new Bank("Mono");
    private Account authenticatedAccount;

    public ATMForm()
    {
        InitializeComponents();
        InitializeTestData();
    }

    private void InitializeComponents()
    {
        tabControl = new TabControl
        {
            Dock = DockStyle.Fill
        };

        userTab = new TabPage("Робота з рахунком");
        addUserTab = new TabPage("Додати користувача");

        InitializeUserTab();
        InitializeAddUserTab();

        tabControl.TabPages.Add(userTab);
        tabControl.TabPages.Add(addUserTab);

        this.Controls.Add(tabControl);
        this.Text = "Банкомат";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Width = 350;
        this.Height = 600;
    }

    private void InitializeUserTab()
    {
        Label cardNumberLabel = new Label
        {
            Text = "Номер картки:",
            Top = 20,
            Left = 20
        };
        cardNumberTextBox = new TextBox
        {
            Top = 50,
            Left = 20,
            Width = 200
        };

        Label pinCodeLabel = new Label
        {
            Text = "PIN-код:",
            Top = 90,
            Left = 20
        };
        pinCodeTextBox = new TextBox
        {
            Top = 120,
            Left = 20,
            Width = 200
        };

        loginLogoutButton = new Button
        {
            Text = "Увійти",
            Top = 160,
            Left = 20
        };
        loginLogoutButton.Click += LoginLogoutButton_Click;

        checkBalanceButton = new Button
        {
            Text = "Перевірити баланс",
            Top = 200,
            Left = 20
        };
        checkBalanceButton.Click += CheckBalanceButton_Click;

        balanceLabel = new Label
        {
            Text = "Ваш баланс: 0 грн.",
            Top = 240,
            Left = 20,
            Width = 250
        };

        amountTextBox = new TextBox
        {
            Top = 280,
            Left = 20,
            Width = 200,
            PlaceholderText = "Введіть суму"
        };

        transferCardTextBox = new TextBox
        {
            Top = 320,
            Left = 20,
            Width = 200,
            PlaceholderText = "Картка отримувача"
        };

        withdrawButton = new Button
        {
            Text = "Зняти кошти",
            Top = 360,
            Left = 20
        };
        withdrawButton.Click += WithdrawButton_Click;

        depositButton = new Button
        {
            Text = "Зарахувати кошти",
            Top = 400,
            Left = 20
        };
        depositButton.Click += DepositButton_Click;

        transferButton = new Button
        {
            Text = "Переказати кошти",
            Top = 440,
            Left = 20
        };
        transferButton.Click += TransferButton_Click;

        userTab.Controls.Add(cardNumberLabel);
        userTab.Controls.Add(cardNumberTextBox);
        userTab.Controls.Add(pinCodeLabel);
        userTab.Controls.Add(pinCodeTextBox);
        userTab.Controls.Add(loginLogoutButton);
        userTab.Controls.Add(checkBalanceButton);
        userTab.Controls.Add(balanceLabel);
        userTab.Controls.Add(amountTextBox);
        userTab.Controls.Add(transferCardTextBox);
        userTab.Controls.Add(withdrawButton);
        userTab.Controls.Add(depositButton);
        userTab.Controls.Add(transferButton);

        SetControlsEnabled(false);
    }

    private void InitializeAddUserTab()
    {
        Label newClientLabel = new Label
        {
            Text = "Додати нового клієнта",
            Top = 20,
            Left = 20
        };

        Label newCardNumberLabel = new Label
        {
            Text = "Номер картки:",
            Top = 50,
            Left = 20
        };
        newCardNumberTextBox = new TextBox
        {
            Top = 80,
            Left = 20,
            Width = 200
        };

        Label newClientNameLabel = new Label
        {
            Text = "Ім'я клієнта:",
            Top = 110,
            Left = 20
        };
        newClientNameTextBox = new TextBox
        {
            Top = 140,
            Left = 20,
            Width = 200
        };

        Label newPinCodeLabel = new Label
        {
            Text = "PIN-код:",
            Top = 170,
            Left = 20
        };
        newPinCodeTextBox = new TextBox
        {
            Top = 200,
            Left = 20,
            Width = 200
        };

        Label newInitialBalanceLabel = new Label
        {
            Text = "Початковий баланс:",
            Top = 230,
            Left = 20
        };
        newInitialBalanceTextBox = new TextBox
        {
            Top = 260,
            Left = 20,
            Width = 200
        };

        addNewClientButton = new Button
        {
            Text = "Додати клієнта",
            Top = 300,
            Left = 20
        };
        addNewClientButton.Click += AddNewClientButton_Click;

        addUserTab.Controls.Add(newClientLabel);
        addUserTab.Controls.Add(newCardNumberLabel);
        addUserTab.Controls.Add(newCardNumberTextBox);
        addUserTab.Controls.Add(newClientNameLabel);
        addUserTab.Controls.Add(newClientNameTextBox);
        addUserTab.Controls.Add(newPinCodeLabel);
        addUserTab.Controls.Add(newPinCodeTextBox);
        addUserTab.Controls.Add(newInitialBalanceLabel);
        addUserTab.Controls.Add(newInitialBalanceTextBox);
        addUserTab.Controls.Add(addNewClientButton);
    }

    private void SetControlsEnabled(bool isEnabled)
    {
        checkBalanceButton.Enabled = isEnabled;
        withdrawButton.Enabled = isEnabled;
        depositButton.Enabled = isEnabled;
        transferButton.Enabled = isEnabled;
        amountTextBox.Enabled = isEnabled;
        transferCardTextBox.Enabled = isEnabled;
    }

    private void AddNewClientButton_Click(object sender, EventArgs e)
    {
        try
        {
            var cardNumber = newCardNumberTextBox.Text;
            var name = newClientNameTextBox.Text;
            var pinCode = newPinCodeTextBox.Text;

            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show("Помилка: Номер картки не може бути порожнім.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Помилка: Ім'я клієнта не може бути порожнім.");
                return;
            }

            if (string.IsNullOrWhiteSpace(pinCode))
            {
                MessageBox.Show("Помилка: PIN-код не може бути порожнім.");
                return;
            }

            if (decimal.TryParse(newInitialBalanceTextBox.Text, out var balance))
            {
                bank.AddAccount(new Account(cardNumber, name, pinCode, balance));
                MessageBox.Show("Новий клієнт успішно доданий.");
                newCardNumberTextBox.Clear();
                newClientNameTextBox.Clear();
                newPinCodeTextBox.Clear();
                newInitialBalanceTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Помилка: Введено некоректну суму для балансу.");
            }
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show($"Помилка: {ex.Message}");
        }
        catch (Exception)
        {
            MessageBox.Show("Помилка: Сталася помилка під час додавання нового клієнта. Спробуйте ще раз.");
        }
    }


    private void CheckBalanceButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            UpdateBalanceLabel();
        }
    }

    private void WithdrawButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            try
            {
                if (decimal.TryParse(amountTextBox.Text, out var amount))
                {
                    authenticatedAccount.OnWithdraw += message => MessageBox.Show(message);
                    bank.GetAtm("ATM1").ProcessWithdrawal(authenticatedAccount, amount);
                    UpdateBalanceLabel();
                }
                else
                {
                    MessageBox.Show("Помилка: Введено некоректну суму.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка: Неможливо виконати зняття коштів. Перевірте баланс або спробуйте ще раз.");
            }
        }
    }

    private void DepositButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            try
            {
                if (decimal.TryParse(amountTextBox.Text, out var amount))
                {
                    authenticatedAccount.OnDeposit += message => MessageBox.Show(message);
                    bank.GetAtm("ATM1").ProcessDeposit(authenticatedAccount, amount);
                    UpdateBalanceLabel();
                }
                else
                {
                    MessageBox.Show("Помилка: Введено некоректну суму.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка: Неможливо виконати зарахування. Спробуйте ще раз.");
            }
        }
    }

    private void TransferButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            try
            {
                var transferCard = transferCardTextBox.Text;
                if (string.IsNullOrWhiteSpace(transferCard))
                {
                    MessageBox.Show("Помилка: Номер картки отримувача не може бути порожнім.");
                    return;
                }

                if (decimal.TryParse(amountTextBox.Text, out var amount))
                {
                    var recipientAccount = bank.GetAccount(transferCard);
                    if (recipientAccount != null)
                    {
                        bank.GetAtm("ATM1").ProcessTransfer(authenticatedAccount, recipientAccount, amount);
                        UpdateBalanceLabel();
                    }
                    else
                    {
                        MessageBox.Show("Помилка: Невірний номер картки отримувача.");
                    }
                }
                else
                {
                    MessageBox.Show("Помилка: Введено некоректну суму.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка: Неможливо виконати переказ коштів. Перевірте дані та спробуйте ще раз.");
            }
        }
    }

    private void UpdateBalanceLabel()
    {
        balanceLabel.Text = $"Ваш баланс: {authenticatedAccount.Balance} грн.";
    }

    private void LoginLogoutButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount == null)
        {
            try
            {
                if (AuthenticateUser() != null)
                {
                    MessageBox.Show("Авторизація успішна!");
                    loginLogoutButton.Text = "Вийти";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка: Сталася помилка під час авторизації. Спробуйте ще раз.");
            }
        }
        else
        {
            Logout();
        }
    }

    private Account AuthenticateUser()
    {
        try
        {
            var cardNumber = cardNumberTextBox.Text;
            var pinCode = pinCodeTextBox.Text;

            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show("Помилка: Номер картки не може бути порожнім.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(pinCode))
            {
                MessageBox.Show("Помилка: PIN-код не може бути порожнім.");
                return null;
            }

            var account = bank.GetAccount(cardNumber);
            if (account != null && account.Authenticate(cardNumber, pinCode))
            {
                authenticatedAccount = account;
                SetControlsEnabled(true);
                UpdateBalanceLabel();
                return account;
            }
            else
            {
                MessageBox.Show("Помилка: Невірний номер картки або PIN-код.");
                return null;
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Помилка: Сталася помилка під час авторизації. Спробуйте ще раз.");
            return null;
        }
    }

    private void Logout()
    {
        authenticatedAccount = null;
        SetControlsEnabled(false);
        cardNumberTextBox.Clear();
        pinCodeTextBox.Clear();
        amountTextBox.Clear();
        transferCardTextBox.Clear();
        balanceLabel.Text = "Ваш баланс: 0 грн.";
        loginLogoutButton.Text = "Увійти";
        MessageBox.Show("Ви вийшли з системи.");
    }

    private void InitializeTestData()
    {
        bank.AddAtm(new AutomatedTellerMachine("ATM1", "Чуднівська 103", 10000m));
        bank.AddAccount(new Account("1111 1111 1111 1122", "Іван Іваненко", "1234", 5000m));
        bank.AddAccount(new Account("4441 1111 1234 5678", "Петро Петренко", "5678", 3000m));
    }
}
