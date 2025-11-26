class Program
{
    static void Main(string[] args)
    {
        // Create BankAccount object
        BankAccount account = new BankAccount("ACC12345", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);

        // Deposit money
        account.Deposit(3000);

        // Withdraw money
        account.Withdraw(2500);

        // Print remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);
    }
}
