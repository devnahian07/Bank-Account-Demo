namespace BankAccountNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  Any code will run here when the form starts
            BankAccount bankAccount1 = new();
            bankAccount1.Owner = "Al Nahian";
            bankAccount1.AccountNumber = Guid.NewGuid();
            bankAccount1.Balance = 200;

            BankAccount bankAccount2 = new();
            bankAccount2.Owner = "Elon Musk";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 2000;

            BankAccount bankAccount3 = new();
            bankAccount3.Owner = "Bill Gates";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 1000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount1);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }
    }
}
