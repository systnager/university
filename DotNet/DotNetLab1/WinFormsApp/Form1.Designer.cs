using System;
using System.Windows.Forms;
using ClassLibrary;

public class ATMForm : Form
{
    private TextBox cardNumberTextBox;
    private TextBox pinCodeTextBox;
    private Label balanceLabel;
    private TextBox amountTextBox;
    private TextBox transferCardTextBox;
    private Button withdrawButton;
    private Button depositButton;
    private Button transferButton;
    private Button checkBalanceButton;
    private Button loginLogoutButton;
    private Bank bank = new Bank("Mono");
    private Account authenticatedAccount;

    public ATMForm()
    {
        InitializeComponents();
        InitializeTestData();
    }

    private void InitializeComponents()
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
        
        this.Controls.Add(cardNumberLabel);
        this.Controls.Add(cardNumberTextBox);
        this.Controls.Add(pinCodeLabel);
        this.Controls.Add(pinCodeTextBox);
        this.Controls.Add(loginLogoutButton);
        this.Controls.Add(checkBalanceButton);
        this.Controls.Add(balanceLabel);
        this.Controls.Add(amountTextBox);
        this.Controls.Add(transferCardTextBox);
        this.Controls.Add(withdrawButton);
        this.Controls.Add(depositButton);
        this.Controls.Add(transferButton);
        
        this.Text = "Банкомат";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Width = 300;
        this.Height = 550;
        
        SetControlsEnabled(false);
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
            decimal amount;
            if (decimal.TryParse(amountTextBox.Text, out amount))
            {
                authenticatedAccount.OnWithdraw += message => MessageBox.Show(message);
                bank.GetAtm("ATM1").ProcessWithdrawal(authenticatedAccount, amount);
                UpdateBalanceLabel();
            }
            else
            {
                MessageBox.Show("Невірна сума.");
            }
        }
    }
    
    private void DepositButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            decimal amount;
            if (decimal.TryParse(amountTextBox.Text, out amount))
            {
                authenticatedAccount.OnDeposit += message => MessageBox.Show(message);
                bank.GetAtm("ATM1").ProcessDeposit(authenticatedAccount, amount);
                UpdateBalanceLabel();
            }
            else
            {
                MessageBox.Show("Невірна сума.");
            }
        }
    }
    
    private void TransferButton_Click(object sender, EventArgs e)
    {
        if (authenticatedAccount != null)
        {
            string transferCard = transferCardTextBox.Text;
            decimal amount;
            if (decimal.TryParse(amountTextBox.Text, out amount))
            {
                Account recipientAccount = bank.GetAccount(transferCard);
                if (recipientAccount != null)
                {
                    bank.GetAtm("ATM1").ProcessTransfer(authenticatedAccount, recipientAccount, amount);
                    UpdateBalanceLabel();
                }
                else
                {
                    MessageBox.Show("Невірний номер картки отримувача.");
                }
            }
            else
            {
                MessageBox.Show("Невірна сума.");
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
            if (AuthenticateUser() != null)
            {
                MessageBox.Show("Авторизація успішна!");
                loginLogoutButton.Text = "Вийти";
            }
        }
        else
        {
            Logout();
        }
    }
    
    private Account AuthenticateUser()
    {
        string cardNumber = cardNumberTextBox.Text;
        string pinCode = pinCodeTextBox.Text;

        Account account = bank.GetAccount(cardNumber);
        if (account != null && account.Authenticate(cardNumber, pinCode))
        {
            authenticatedAccount = account;
            SetControlsEnabled(true);
            UpdateBalanceLabel();
            return account;
        }
        else
        {
            MessageBox.Show("Невірний номер картки або PIN-код.");
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
