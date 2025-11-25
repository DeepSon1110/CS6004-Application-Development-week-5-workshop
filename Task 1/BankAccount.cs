public class BankAccount
{
    //private fields
    private string accountNumber;
    private double balance;

    //public properties
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
    }

    //method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    //method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
        }
    }

    //constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        Balance = initialBalance;
    }



}

