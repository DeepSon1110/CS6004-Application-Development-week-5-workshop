class Program
{
    static void Main(String[] args)
    {
        //creating object of Bank Account Class
        BankAccount account = new BankAccount("123456789",50000);

        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Initial Balance: " + account.Balance);

        //depositing amount
        account.Deposit(15000);

        //withdrawing amount
        account.Withdraw(20000);

        //displaying final balance
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}