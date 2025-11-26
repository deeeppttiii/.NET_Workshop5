using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property with only getter (value passed through constructor)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property for balance with private setter
    // Does NOT allow 0 or negative balance
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                throw new Exception("Balance cannot be zero or negative.");
            }
            balance = value;
        }
    }

    // Constructor
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance;  // uses property validation
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited: {amount}");
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero.");
            return;
        }
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrawn: {amount}");
    }
}

